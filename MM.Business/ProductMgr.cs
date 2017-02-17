using MM.Model;
using MM.Model.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Business
{
    internal class ProductMgr : IProductMgr
    {
        IProductRepository _productRepository;
        public ProductMgr(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        /// <summary>
        /// 根据产品Id，获取产品对象
        /// </summary>
        public Product GetById(Guid productId)
        {
            return _productRepository.GetByKey(productId);
        }
    }
}
