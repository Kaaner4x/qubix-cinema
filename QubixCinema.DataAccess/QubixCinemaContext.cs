using QubixCinema.DataAccess.Mappings;
using QubixCinema.Entities.Models;
using System.Data.Entity;

namespace QubixCinema.DataAccess
{
    public class QubixCinemaContext : DbContext
    {
        public QubixCinemaContext() : base("QubixCinemaEFContext") { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Register> Registers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MovieMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new SeatMap());
            modelBuilder.Configurations.Add(new ReservationMap());
            modelBuilder.Configurations.Add(new RegisterMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
