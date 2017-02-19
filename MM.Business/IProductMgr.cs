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

        /// <summary>
        /// 获取系统中所有的产品定义
        /// </summary>
        IEnumerable<Product> GetAll();

        /// <summary>
        /// 保存产品
        /// </summary>
        void Save(Product product);

        /// <summary>
        /// 根据产品Id，删除产品对象
        /// </summary>
        void Delete(Guid productId);
    }
}
