using MM.Model;
using System.Data.Entity.ModelConfiguration;

namespace MM.Repository.Mappings
{
    public class PurchaseConfiguration:EntityTypeConfiguration<Purchase>
    {
        public PurchaseConfiguration()
        {
            ToTable("Purchases");
            HasKey(p => p.Id);
            //Property(p => p.CustomerName).HasMaxLength(10);
            //Property(p => p.PhoneNumber).HasMaxLength(30);
            //Property(p => p.Price).HasColumnType("money");
            Property(p => p.PurchaseDate).HasColumnType("datetime");
            Ignore(p => p.Price);
        }
    }
}
