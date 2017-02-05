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
            ISessionRepository sessionRepository,
            IMediumRepository mediumRepository) :
            base(tutorRepository, productRepository, memberRepository,
                purchaseRepository, balanceRepository, consumptionRepository,
                sessionRepository)
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
        }

        public void AddProduct()
        {

        }

        public void SetProduct()
        {

        }

        public void RemoveProduct()
        {

        }

        public void AddTutor(Tutor tutor)
        {
            _tutorRepository.Add(tutor);
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
        }

        public void RemoveTutor(Guid tutorId)
        {
            var tutor = _tutorRepository.GetByKey(tutorId);
            _tutorRepository.Remove(tutor);
        }

        public void AddMedium(string name)
        {
            ISpecification<Medium> spec = new DirectSpecification<Medium>(m => m.Name == name);
            var medium = _mediumRepository.FindBySpecification(spec).FirstOrDefault();
            if (medium != null) throw new MediumExistException();
            medium = new Medium(name);
            _mediumRepository.Add(medium);
        }

        public void RemoveMedium(Guid mediumId)
        {
            var medium = _mediumRepository.GetByKey(mediumId);
            _mediumRepository.Remove(medium);
        }
    }
}