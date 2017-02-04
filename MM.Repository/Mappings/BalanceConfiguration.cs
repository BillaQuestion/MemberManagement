using MM.Model;
using System.Data.Entity.ModelConfiguration;

namespace MM.Repository.Mappings
{
    public class BalanceConfiguration:EntityTypeConfiguration<Balance>
    {
        public BalanceConfiguration()
        {
            ToTable("Balances");
            //HasRequired(b => b.MemberProduct);
        }
    }
}
