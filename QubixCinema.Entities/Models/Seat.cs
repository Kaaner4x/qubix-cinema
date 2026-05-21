using System.Collections.Generic;

namespace QubixCinema.Entities.Models
{
    public class Seat
    {
        public int SeatId { get; set; }
        public string HallName { get; set; }
        public int SerialNumber { get; set; }
        public int SeatNumber { get; set; }
        public bool isBooked { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
