using MM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Business
{
    public interface IProductMgr
    {
        void Add(Product product);
        
        void Modify(Product product);

        Product Get(Guid productId);

        IEnumerable<Product> GetAll();

        void Remove(Product product);
    }
}
