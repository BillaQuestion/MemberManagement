using MM.Model;
using System.Data.Entity.ModelConfiguration;

namespace MM.Repository.Mappings
{
    public class SessionConfiguration : EntityTypeConfiguration<Session>
    {
        public SessionConfiguration()
        {
            //ToTable("Sessions");
            Property(s => s.Description).HasMaxLength(100);
        }
    }
}
