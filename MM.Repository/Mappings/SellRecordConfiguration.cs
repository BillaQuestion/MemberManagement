using MM.Model;
using System.Data.Entity.ModelConfiguration;

namespace MM.Repository.Mappings
{
    public class SellRecordConfiguration:EntityTypeConfiguration<SellRecord>
    {
        public SellRecordConfiguration()
        {
            ToTable("SellRecords");
            HasKey(p => p.Id);
            Property(p => p.Price).HasColumnType("money");
            Property(p => p.SellDate).HasColumnType("datetime");
        }
    }
}
