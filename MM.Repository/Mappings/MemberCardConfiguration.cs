using MM.Model;
using System.Data.Entity.ModelConfiguration;

namespace MM.Repository.Mappings
{
    public class MemberCardConfiguration:EntityTypeConfiguration<MemberCard>
    {
        public MemberCardConfiguration()
        {
            ToTable("MemberCards");
            HasRequired(mc => mc.SellRecord).WithMany()
                .HasForeignKey(mc => mc.SellRecordId)
                .WillCascadeOnDelete(false);
            HasRequired(mc => mc.Product).WithMany()
                .HasForeignKey(mc => mc.ProductId)
                .WillCascadeOnDelete(false);
        }
    }
}
