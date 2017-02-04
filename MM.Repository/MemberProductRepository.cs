using Dayi.Infrastructure.Data.Seedwork;
using MM.Model;
using MM.Model.IRepositories;

namespace MM.Repository
{
    public class MemberProductRepository:Repository<MemberProduct>, IMemberProductRepository
    {
        public MemberProductRepository(IQueryableUnitOfWork context):base(context)
        { }
    }
}
