using Dayi.Infrastructure.Data.Seedwork;
using MM.Model;
using MM.Model.IRepositories;

namespace MM.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(IQueryableUnitOfWork context):base(context)
        { }
    }
}
