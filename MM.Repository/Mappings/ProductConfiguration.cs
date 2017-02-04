using MM.Model;
using System.Data.Entity.ModelConfiguration;

namespace MM.Repository.Mappings
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            ToTable("Products");
            this.HasKey(p => p.Id);
            this.Property(p => p.Name).HasMaxLength(30);
        }
    }
}
