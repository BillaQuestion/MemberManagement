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
    public class Administrator : TutorMgr
    {
        IMediumRepository _mediumRepository;

        public Administrator(ITutorRepository tutorRepository,
            IProductRepository productRepository,
            IMemberRepository memberRepository,
            IPurchaseRepository purchaseRepository,
            IBalanceRepository balanceRepository,
            IConsumptionRepository consumptionRepository,
            IMediumRepository mediumRepository) :
            base(tutorRepository, productRepository, memberRepository,
                purchaseRepository, balanceRepository, consumptionRepository)
        {
            _mediumRepository = mediumRepository;
        }

        public void SetMember(Guid memberId, Member newMember)
        {
            var member = _memberRepository.GetByKey(memberId);
            member.Address = newMember.Address;
            member.Gender = newMember.Gender;
            member.Name = newMember.Name;
            member.PhoneNumber = newMember.PhoneNumber;
            _memberRepository.Modify(member);

            _memberRepository.UnitOfWork.Commit();
        }

        public void AddProduct(Product product)
        {
            _productRepository.Add(product);

            _productRepository.UnitOfWork.Commit();
        }

        public void SetProduct(Guid productId, Product newProduct)
        {
            var product = _productRepository.GetByKey(productId);
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
            _productRepository.Modify(product);

            _productRepository.UnitOfWork.Commit();            
        }

        public void RemoveProduct(Guid productId)
        {
            var product = _productRepository.GetByKey(productId);
            _productRepository.Remove(product);

            _productRepository.UnitOfWork.Commit();
        }

        public void AddTutor(Tutor tutor)
        {
            _tutorRepository.Add(tutor);

            _tutorRepository.UnitOfWork.Commit();
        }

        public void SetTutor(Guid tutorId, Tutor newTutor)
        {
            var tutor = _tutorRepository.GetByKey(tutorId);
            tutor.Address = newTutor.Address;
            tutor.Gender = newTutor.Gender;
            tutor.IsManager = newTutor.IsManager;
            tutor.Name = newTutor.Name;
            tutor.PhoneNumber = newTutor.PhoneNumber;
            _tutorRepository.Modify(tutor);

            _tutorRepository.UnitOfWork.Commit();
        }

        public void RemoveTutor(Guid tutorId)
        {
            var tutor = _tutorRepository.GetByKey(tutorId);
            _tutorRepository.Remove(tutor);

            _tutorRepository.UnitOfWork.Commit();
        }

        public void AddMedium(string name)
        {
            ISpecification<Medium> spec = new DirectSpecification<Medium>(m => m.Name == name);
            var medium = _mediumRepository.FindBySpecification(spec).FirstOrDefault();
            if (medium != null) throw new MediumExistException();
            medium = new Medium() { Name = name };
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