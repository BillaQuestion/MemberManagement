using Dayi.Infrastructure.Data.Seedwork;
using MM.Model;
using MM.Model.IRepositories;

namespace MM.Repository
{
    public class TutorRepository : Repository<Tutor>, ITutorRepository
    {
        public TutorRepository(IQueryableUnitOfWork context):base(context)
        { }
    }
}
