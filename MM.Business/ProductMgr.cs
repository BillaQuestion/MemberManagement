﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MM.Model;
using MM.Model.IRepositories;

namespace MM.Business
{
    public class ProductMgr : IProductMgr
    {
        IProductRepository _productRepository;

        public ProductMgr(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        void IProductMgr.Add(Product product)
        {
            _productRepository.Add(product);

            _productRepository.UnitOfWork.Commit();
        }

        void CreateProduct(string name, decimal price)
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
    }
}