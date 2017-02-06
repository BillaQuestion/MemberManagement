using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MM.Model;
using MM.Model.IRepositories;
using Dayi.Infrastructure.Data.Seedwork;

namespace MM.Repository
{
    public class PurchaseRepository : Repository<Purchase>, IPurchaseRepository
    {
        public PurchaseRepository(IQueryableUnitOfWork unitOfWork) : base(unitOfWork) { }
    }
}
