using MM.Model;
using System.Data.Entity.ModelConfiguration;

namespace MM.Repository.Mappings
{
    public class MemberCardConfiguration:EntityTypeConfiguration<MemberCard>
    {
        public MemberCardConfiguration()
        {
            ToTable("MemberCards");
            //HasRequired(b => b.MemberProduct);
        }
    }
}
