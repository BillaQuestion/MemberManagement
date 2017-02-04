using MM.Model;
using System.Data.Entity.ModelConfiguration;

namespace MM.Repository.Mappings
{
    public class TutorConfiguration:EntityTypeConfiguration<Tutor>
    {
        public TutorConfiguration()
        {
            ToTable("Tutors");
            Property(t => t.Name).HasMaxLength(10);
            Property(t => t.PhoneNumber).HasMaxLength(30);
            Property(t => t.Address).HasMaxLength(100);
        }
    }
}
