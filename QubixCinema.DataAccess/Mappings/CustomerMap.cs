using QubixCinema.Entities.Models;
using System.Data.Entity.ModelConfiguration;

namespace QubixCinema.DataAccess.Mappings
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customers");

            HasKey(c => c.CustomerId);

            Property(c => c.CustomerFirstName).IsRequired().HasMaxLength(50);

            Property(c => c.CustomerLastName).IsRequired().HasMaxLength(50);

            Property(c => c.PhoneNumber).IsRequired().HasMaxLength(50);

            Property(c => c.Email).IsRequired().HasMaxLength(50);

            HasMany(m => m.Reservations)
                .WithRequired(c => c.Customer)
                .HasForeignKey(r => r.CustomerId)
                .WillCascadeOnDelete(false);
        }
    }
}
