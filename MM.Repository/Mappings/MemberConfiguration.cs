using MM.Model;
using System.Data.Entity.ModelConfiguration;

namespace MM.Repository.Mappings
{
    public class MemberConfiguration:EntityTypeConfiguration<Member>
    {
        public MemberConfiguration()
        {
            ToTable("Members");
            Property(m => m.Name).HasMaxLength(10);
            Property(m => m.PhoneNumber).HasMaxLength(40);
            Property(m => m.Address).HasMaxLength(100);
        }
    }
}
