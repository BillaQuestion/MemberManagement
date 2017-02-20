using MM.Model;
using MM.Model.Exceptions;
using MM.Model.IRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MM.Business
{
    public class ProductMgr : IProductMgr
    {
        IProductRepository _productRepository;
        public ProductMgr(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        /// <summary>
        /// 根据产品Id，获取产品对象
        /// </summary>
        Product IProductMgr.GetById(Guid productId)
        {
            return _productRepository.GetByKey(productId);
        }

        /// <summary>
        /// 获取系统中所有的产品定义
        /// </summary>
        IEnumerable<Product> IProductMgr.GetAll()
        {
            return _productRepository.GetAll();
        }

        /// <summary>
        /// 保存产品
        /// </summary>
        void IProductMgr.Save(Product product)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(product,
                new ValidationContext(product),
                results);
            if (isValid)
                throw new ArgumentException("产品数据不合法！");

            if (product.IsTransient())
            {
                product.GenerateNewIdentity();
                _productRepository.Add(product);
            }
            else
                _productRepository.Modify(product);

            _productRepository.UnitOfWork.Commit();
        }

        /// <summary>
        /// 根据产品Id，删除产品对象
        /// </summary>
        void IProductMgr.Delete(Guid productId)
        {
            var product = (this as IProductMgr).GetById(productId);
            if (product == null)
                throw new ProductNotExistException(string.Format("产品[{0}]不存在！", productId));

            _productRepository.Remove(product);
            _productRepository.UnitOfWork.Commit();
        }
    }
}
