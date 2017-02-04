using MM.Model;
using System.Data.Entity.ModelConfiguration;

namespace MM.Repository.Mappings
{
    public class MediumConfiguration:EntityTypeConfiguration<Medium>
    {
        public MediumConfiguration()
        {
            ToTable("Mediums");
            Property(m => m.Name).HasMaxLength(30);
        }
    }
}
