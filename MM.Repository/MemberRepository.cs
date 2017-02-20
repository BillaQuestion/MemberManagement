using Dayi.Data.Domain.Seedwork.Specification;
using Dayi.Infrastructure.Data.Seedwork;
using MM.Model;
using MM.Model.IRepositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MM.Repository
{
    public class MemberRepository : Repository<Member>, IMemberRepository
    {
        public MemberRepository(IQueryableUnitOfWork context) : base(context) { }

        public override IQueryable<Member> FindBySpecification(ISpecification<Member> specification)
        {
            return base.FindBySpecification(specification).Include(o => o.Balances);
        }

        public override IEnumerable<Member> GetAll()
        {
            var members = base.GetAll();
            foreach (var member in members)
                (UnitOfWork as MMContext).Entry(member).Collection(o => o.Balances).Load();

            return members;
        }

        public override Member GetByKey(params object[] keyValues)
        {
            var member = base.GetByKey(keyValues);
            if (member != null)
                (UnitOfWork as MMContext).Entry(member).Collection(o => o.Balances).Load();

            return member;
        }
    }
}
