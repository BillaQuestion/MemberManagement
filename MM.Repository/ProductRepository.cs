using System.Collections.Generic;
using Dayi.Infrastructure.Data.Seedwork;
using MM.Model;
using MM.Model.IRepositories;
using System.Linq;

namespace MM.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(IQueryableUnitOfWork context):base(context)
        { }

        public override Product GetByKey(params object[] keyValues)
        {
            var product = base.GetByKey(keyValues);
            if (product != null)
                (UnitOfWork as MMContext).Entry(product).Reference(p => p.Medium).Load();

            return product;
        }
    }
}
