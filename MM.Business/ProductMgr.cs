using MM.Model;
using MM.Model.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MM.Model.Enums;

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

        void IProductMgr.AddProduct(Product product)
        {
            _productRepository.Add(product);

            _productRepository.UnitOfWork.Commit();
        }

        public void AddProduct(string name, decimal price)
        {
            var ote = new OneTimeExperience()
            {
                Name = name,
                Price = price
            };
            if (ote.IsTransient())
                ote.GenerateNewIdentity();
            _productRepository.Add(ote);

            _productRepository.UnitOfWork.Commit();
        }

        void CreateProduct(string name, decimal price, int count, Medium medium)
        {
            var timesCard = new TimesCard()
            {
                Name = name,
                Price = price,
                Count = count,
                Medium = medium
            };
            if (timesCard.IsTransient())
                timesCard.GenerateNewIdentity();
            _productRepository.Add(timesCard);

            _productRepository.UnitOfWork.Commit();
        }

        void CreateProduct(string name, decimal price, int count, string description)
        {
            var lecture = new Lecture()
            {
                Name = name,
                Price = price,
                Count = count,
                Description = description
            };
            if (lecture.IsTransient())
                lecture.GenerateNewIdentity();
            _productRepository.Add(lecture);

            _productRepository.UnitOfWork.Commit();
        }

        IEnumerable<Product> IProductMgr.GetAll()
        {
            return _productRepository.GetAll();
        }

        Product IProductMgr.Get(Guid productId)
        {
            return _productRepository.GetByKey(productId);
        }

        void IProductMgr.Modify(Product product)
        {
            _productRepository.Modify(product);

            _productRepository.UnitOfWork.Commit();
        }

        void IProductMgr.Remove(Product product)
        {
            _productRepository.Remove(product);

            _productRepository.UnitOfWork.Commit();
        }

        IEnumerable<Product> IProductMgr.GetAll(ProductTypes productTypes)
        {
            var result = new List<Product>();
            foreach (var product in _productRepository.GetAll())
            {
                switch (productTypes)
                {
                    case ProductTypes.Lecture:
                        if (product is Lecture)
                            result.Add(product);
                        break;
                    case ProductTypes.OneTimeExperience:
                        if (product is OneTimeExperience)
                            result.Add(product);
                        break;
                    case ProductTypes.TimesCard:
                        if (product is TimesCard)
                            result.Add(product);
                        break;
                }
            }
            return result;
        }
    }
}
