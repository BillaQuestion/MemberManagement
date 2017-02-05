using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MM.Model.IRepositories;
using MM.Model;
using Dayi.Infrastructure.Data.Seedwork;

namespace MM.Repository
{
    public class MediumRepository : Repository<Medium>, IMediumRepository
    {
        public MediumRepository(IQueryableUnitOfWork unitOfWork) : base(unitOfWork) { }
    }
}
