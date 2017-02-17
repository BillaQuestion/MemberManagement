using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MM.Model;
using MM.Model.IRepositories;
using Dayi.Data.Domain.Seedwork.Specification;
using MM.Business.Exceptions;

namespace MM.Business
{
    public class Administrator : StudioService
    {
        IMediumRepository _mediumRepository;

        public Administrator(ITutorMgr tutorMgr,
            IProductMgr productMgr,
            IMemberMgr memberMgr,
            IPurchaseMgr purchaseMgr,
            IConsumptionMgr consumptionMgr,
            IMediumRepository mediumRepository) :
            base(tutorMgr, productMgr, memberMgr,
                purchaseMgr, consumptionMgr)
        {
            _mediumRepository = mediumRepository;
        }

        public void AddProduct(Product product)
        {
            _productMgr.Save(product);

            _productMgr.UnitOfWork.Commit();
        }

        public void SetProduct(Guid productId, Product newProduct)
        {
            var product = _productMgr.GetByKey(productId);
            product.Name = newProduct.Name;
            product.Price = newProduct.Price;
            if(newProduct is MemberProduct)
            {
                var np = newProduct as MemberProduct;
                var mp = product as MemberProduct;
                mp.Count = np.Count;
                if(newProduct is Lecture)
                {
                    var lnp = newProduct as Lecture;
                    var lp = product as Lecture;
                    lp.Description = lnp.Description;
                }
                else
                {
                    var tnp = newProduct as TimesCard;
                    var tp = product as TimesCard;
                    tp.Medium = tnp.Medium;
                }
            }
            _productMgr.Modify(product);

            _productMgr.UnitOfWork.Commit();            
        }

        public void RemoveProduct(Guid productId)
        {
            var product = _productMgr.GetByKey(productId);
            _productMgr.Remove(product);

            _productMgr.UnitOfWork.Commit();
        }

        public void AddTutor(Tutor tutor)
        {
            _tutorMgr.Add(tutor);

            _tutorMgr.UnitOfWork.Commit();
        }

        public void SetTutor(Guid tutorId, Tutor newTutor)
        {
            var tutor = _tutorMgr.GetByKey(tutorId);
            tutor.Address = newTutor.Address;
            tutor.Gender = newTutor.Gender;
            tutor.IsManager = newTutor.IsManager;
            tutor.Name = newTutor.Name;
            tutor.PhoneNumber = newTutor.PhoneNumber;
            _tutorMgr.Modify(tutor);

            _tutorMgr.UnitOfWork.Commit();
        }

        public void RemoveTutor(Guid tutorId)
        {
            var tutor = _tutorMgr.GetByKey(tutorId);
            _tutorMgr.Remove(tutor);

            _tutorMgr.UnitOfWork.Commit();
        }

        public void AddMedium(Medium medium)
        {
            ISpecification<Medium> spec = new DirectSpecification<Medium>(m => m.Name == medium.Name);
            var result = _mediumRepository.FindBySpecification(spec).FirstOrDefault();
            if (result != null) throw new MediumExistException();

            _mediumRepository.Add(medium);
            _mediumRepository.UnitOfWork.Commit();
        }

        public void RemoveMedium(Guid mediumId)
        {
            var medium = _mediumRepository.GetByKey(mediumId);
            _mediumRepository.Remove(medium);

            _mediumRepository.UnitOfWork.Commit();
        }
    }
}