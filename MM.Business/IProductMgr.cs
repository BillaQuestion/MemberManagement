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
        /// <summary>
        /// 根据产品Id，获取产品对象
        /// </summary>
        Product GetById(Guid productId);

        void AddProduct(Product product);
        
        void ModifyProduct(Product product);

        Product GetProduct(Guid productId);

        IEnumerable<Product> GetAllProducts();

        void RemoveProduct(Product product);
    }
}
