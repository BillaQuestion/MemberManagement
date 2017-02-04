using Dayi.Infrastructure.Data.Seedwork;
using MM.Model;
using MM.Model.IRepositories;

namespace MM.Repository
{
    public class TimesCardRepository: Repository<TimesCard>, ITimesCardRepository
    {
        public TimesCardRepository(IQueryableUnitOfWork context):base(context)
        { }
    }
}
