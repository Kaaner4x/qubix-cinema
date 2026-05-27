using QubixCinema.Entities.Models;
using System.Linq;

namespace QubixCinema.DataAccess
{
    public class DatabaseSeeder
    {
        private readonly QubixCinemaContext _context;

        public DatabaseSeeder(QubixCinemaContext context)
        {
            _context = context;
        }

        public void SeedSeats()
        {
            // Seed 5 realistic cinema halls (Hall A to Hall E) with 50 seats each if the table is empty
            if (!_context.Seats.Any())
            {
                char[] halls = { 'A', 'B', 'C', 'D', 'E' };

                foreach (char hall in halls)
                {
                    for (int i = 1; i <= 50; i++)
                    {
                        _context.Seats.Add(new Seat
                        {
                            HallName = $"Hall {hall}",
                            SerialNumber = (i - 1) / 10 + 1,
                            SeatNumber = i,
                            isBooked = false,
                        });
                    }
                }
                _context.SaveChanges();
            }
        }
    }
}
