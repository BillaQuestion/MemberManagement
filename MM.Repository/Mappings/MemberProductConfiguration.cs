using MM.Model;
using System.Data.Entity.ModelConfiguration;

namespace MM.Repository.Mappings
{
    public class MemberProductConfiguration:EntityTypeConfiguration<MemberProduct>
    {
        public MemberProductConfiguration()
        {
            //ToTable("MemberProducts");
        }
    }
}
