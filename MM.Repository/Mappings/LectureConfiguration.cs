using MM.Model;
using System.Data.Entity.ModelConfiguration;

namespace MM.Repository.Mappings
{
    public class LectureConfiguration:EntityTypeConfiguration<Lecture>
    {
        public LectureConfiguration()
        {
            //ToTable("Lectures");
            Property(l => l.Description).HasMaxLength(200);
        }
    }
}
