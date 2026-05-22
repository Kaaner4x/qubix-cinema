using System;
using System.Collections.Generic;

namespace QubixCinema.Entities.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Genre { get; set; }
        public int Runtime { get; set; }
        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
