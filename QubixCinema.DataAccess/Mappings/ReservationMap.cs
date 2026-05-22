using QubixCinema.Entities.Models;
using System.Data.Entity.ModelConfiguration;

namespace QubixCinema.DataAccess.Mappings
{
    public class ReservationMap : EntityTypeConfiguration<Reservation>
    {
        public ReservationMap()
        {
            ToTable("Reservations");

            HasKey(r => r.ReservationId);

            Property(r => r.ReservationDate).IsRequired().HasColumnType("datetime");

            HasRequired(r => r.Movie)
                .WithMany(m => m.Reservations)
                .HasForeignKey(r => r.MovieId)
                .WillCascadeOnDelete(false);

            HasRequired(r => r.Customer)
                .WithMany(c => c.Reservations)
                .HasForeignKey(c => c.CustomerId)
                .WillCascadeOnDelete(false);

            HasRequired(r => r.Seat)
                .WithMany(s => s.Reservations)
                .HasForeignKey(r => r.SeatId)
                .WillCascadeOnDelete(false);
        }
    }
}
