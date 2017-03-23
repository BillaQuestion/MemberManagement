using MM.Model;
using System.Data.Entity.ModelConfiguration;

namespace MM.Repository.Mappings
{
    public class MemberCardConfiguration:EntityTypeConfiguration<MemberCard>
    {
        public MemberCardConfiguration()
        {
            ToTable("MemberCards");
            HasRequired(mc => mc.SellRecord).WithOptional().WillCascadeOnDelete(false);
            HasRequired(mc => mc.Product).WithOptional().WillCascadeOnDelete(false);
        }
    }
}
