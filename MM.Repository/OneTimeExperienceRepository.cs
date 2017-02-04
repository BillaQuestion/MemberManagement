using Dayi.Infrastructure.Data.Seedwork;
using MM.Model;
using MM.Model.IRepositories;

namespace MM.Repository
{
    public class OneTimeExperienceRepository : Repository<OneTimeExperience>, IOneTimeExperienceRepository
    {
        public OneTimeExperienceRepository(IQueryableUnitOfWork context):base(context)
        { }
    }
}
