using MM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Business
{
    interface IProductMgr
    {
        void AddProduct(Product product);
        
        void ModifyProduct(Product product);

        Product GetProduct(Guid productId);

        IEnumerable<Product> GetAllProducts();

        void RemoveProduct(Product product);
    }
}
