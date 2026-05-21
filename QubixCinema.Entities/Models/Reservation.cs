using System;

namespace QubixCinema.Entities.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int MovieId { get; set; }
        public int CustomerId { get; set; }
        public int SeatId { get; set; }
        public DateTime ReservationDate { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Seat Seat { get; set; }
    }
}
