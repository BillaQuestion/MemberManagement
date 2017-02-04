using Dayi.Infrastructure.Data.Seedwork;
using MM.Model;
using MM.Model.IRepositories;

namespace MM.Repository
{
    public class LectureRepository:Repository<Lecture>, ILectureRepository
    {
        public LectureRepository(IQueryableUnitOfWork context):base(context)
        { }
    }
}
