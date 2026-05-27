using QubixCinema.DataAccess;
using QubixCinema.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace QubixCinema.Business.Services
{
    public class ReservationService
    {
        private readonly QubixCinemaContext _context;

        public ReservationService(QubixCinemaContext context)
        {
            _context = context;
        }

        public List<Reservation> GetAllReservations()
        {
            return _context.Reservations
                .Include(r => r.Movie)
                .Include(r => r.Customer)
                .Include(r => r.Seat)
                .ToList();
        }

        public Reservation GetReservationBySeatId(int seatId)
        {
            return _context.Reservations
                .Include(r => r.Movie)
                .Include(r => r.Customer)
                .Include(r => r.Seat)
                .FirstOrDefault(r => r.SeatId == seatId);
        }

        public void CreateReservation(int movieId, int customerId, int seatId, DateTime reservationDate)
        {
            // Begin a transaction to ensure both reservation and seat state are updated atomically
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var seat = _context.Seats.FirstOrDefault(s => s.SeatId == seatId);
                    if (seat == null)
                        throw new Exception("Seat not found.");

                    if (seat.isBooked)
                        throw new Exception("Seat is already booked.");

                    // 1. Mark seat as booked
                    seat.isBooked = true;

                    // 2. Create the reservation
                    var newReservation = new Reservation
                    {
                        MovieId = movieId,
                        CustomerId = customerId,
                        SeatId = seatId,
                        ReservationDate = reservationDate
                    };
                    _context.Reservations.Add(newReservation);

                    // 3. Log to cash register (Ticket Sale: 15.00 USD)
                    var movieName = _context.Movies.Where(m => m.MovieId == movieId).Select(m => m.MovieName).FirstOrDefault();
                    var customerName = _context.Customers.Where(c => c.CustomerId == customerId).Select(c => c.CustomerFirstName + " " + c.CustomerLastName).FirstOrDefault();
                    
                    var registerEntry = new Register
                    {
                        Amount = 15.00m,
                        Description = $"Ticket Sale - {movieName} - Seat {seat.SerialNumber}-{seat.SeatNumber} (Customer: {customerName})",
                        TransactionDate = DateTime.Now
                    };
                    _context.Registers.Add(registerEntry);

                    _context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void CancelReservation(int reservationId)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var reservation = _context.Reservations
                        .Include(r => r.Seat)
                        .FirstOrDefault(r => r.ReservationId == reservationId);

                    if (reservation == null)
                        throw new Exception("Reservation not found.");

                    // 1. Free the seat
                    if (reservation.Seat != null)
                    {
                        reservation.Seat.isBooked = false;
                    }

                    // 2. Add refund or cancellation record in cash register (-15.00 USD)
                    var registerEntry = new Register
                    {
                        Amount = -15.00m,
                        Description = $"Ticket Refund/Cancellation - Res #{reservationId} (Seat {reservation.Seat?.SerialNumber}-{reservation.Seat?.SeatNumber})",
                        TransactionDate = DateTime.Now
                    };
                    _context.Registers.Add(registerEntry);

                    // 3. Remove reservation
                    _context.Reservations.Remove(reservation);

                    _context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
