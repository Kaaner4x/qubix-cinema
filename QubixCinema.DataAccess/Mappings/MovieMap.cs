using QubixCinema.Entities.Models;
using System.Data.Entity.ModelConfiguration;

namespace QubixCinema.DataAccess.Mappings
{
    public class MovieMap : EntityTypeConfiguration<Movie>
    {
        public MovieMap()
        {
            ToTable("Movies");

            HasKey(m => m.MovieId);

            Property(m => m.MovieName).IsRequired().HasMaxLength(75);

            Property(m => m.Genre).IsRequired().HasMaxLength(50);

            Property(m => m.Runtime).IsRequired();

            Property(m => m.ReleaseDate).IsRequired().HasColumnType("datetime");

            HasMany(m => m.Reservations)
            .WithRequired(r => r.Movie)
            .HasForeignKey(r => r.MovieId)
            .WillCascadeOnDelete(false);
        }
    }
}
