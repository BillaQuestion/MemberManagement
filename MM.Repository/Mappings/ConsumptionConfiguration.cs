using MM.Model;
using System.Data.Entity.ModelConfiguration;

namespace MM.Repository.Mappings
{
    public class ConsumptionConfiguration:EntityTypeConfiguration<Consumption>
    {
        public ConsumptionConfiguration()
        {
            ToTable("Consumptions");
            Property(c => c.ConsumeDate).HasColumnType("DateTime");
        }
    }
}
