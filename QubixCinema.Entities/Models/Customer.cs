using System.Collections.Generic;

namespace QubixCinema.Entities.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
