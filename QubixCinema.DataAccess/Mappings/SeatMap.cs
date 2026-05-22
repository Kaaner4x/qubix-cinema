using QubixCinema.Entities.Models;
using System.Data.Entity.ModelConfiguration;

namespace QubixCinema.DataAccess.Mappings
{
    public class SeatMap : EntityTypeConfiguration<Seat>
    {
        public SeatMap()
        {
            ToTable("Seats");

            HasKey(s => s.SeatId);

            Property(s => s.HallName).IsRequired().HasMaxLength(50);

            Property(s => s.SerialNumber).IsRequired();

            Property(s => s.SeatNumber).IsRequired();

            Property(s => s.isBooked).IsRequired();

            HasMany(s => s.Reservations)
                .WithRequired(r => r.Seat)
                .HasForeignKey(r => r.SeatId)
                .WillCascadeOnDelete(false);
        }
    }
}
