using Dayi.Infrastructure.Data.Seedwork;
using MM.Model;
using MM.Model.IRepositories;

namespace MM.Repository
{
    public class MemberCardRepository:Repository<MemberCard>, IMemberCardRepository
    {
        public MemberCardRepository(IQueryableUnitOfWork context) : base(context) { }
    }
}
