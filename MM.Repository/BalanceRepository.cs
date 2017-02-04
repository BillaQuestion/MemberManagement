using Dayi.Infrastructure.Data.Seedwork;
using MM.Model;
using MM.Model.IRepositories;

namespace MM.Repository
{
    public class BalanceRepository:Repository<Balance>, IBalanceRepository
    {
        public BalanceRepository(IQueryableUnitOfWork context) : base(context) { }
    }
}
