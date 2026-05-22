using QubixCinema.Entities.Models;
using System.Data.Entity.ModelConfiguration;

namespace QubixCinema.DataAccess.Mappings
{
    public class RegisterMap : EntityTypeConfiguration<Register>
    {
        public RegisterMap()
        {
            ToTable("Register");

            HasKey(rg => rg.RegisterId);

            Property(rg => rg.Amount).IsRequired().HasColumnType("money");

            Property(rg => rg.Description).IsRequired().HasMaxLength(200);

            Property(rg => rg.TransactionDate).IsRequired().HasColumnType("datetime");
        }
    }
}
