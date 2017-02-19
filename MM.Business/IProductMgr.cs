using MM.Model;
using MM.Model.Enums;
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
        
        void Modify(Product product);

        Product Get(Guid productId);

        IEnumerable<Product> GetAll();

        void Remove(Product product);
    }
}
