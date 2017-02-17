using MM.Business.Exceptions;
using MM.Model;
using MM.Model.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Business
{
    public class StudioServiceByMgrs
    {
        private IMemberMgr _memberMgr;
        private IProductMgr _productMgr;
        private ITutorMgr _tutorMgr;
        private IPurchaseRepository _purchaseRepository;
        private IBalanceMgr _balanceMgr;
        private IConsumptionRepository _consumptionRepository;

        public StudioServiceByMgrs(IProductMgr productMgr,
            IMemberMgr memberMgr, ITutorMgr tutorMgr,
            IPurchaseRepository purchaseRepository,
            IBalanceMgr balanceMgr,
            IConsumptionRepository consumptionRepository)

        {
            _memberMgr = memberMgr;
            _productMgr = productMgr;
            _tutorMgr = tutorMgr;
            _purchaseRepository = purchaseRepository;
            _balanceMgr = balanceMgr;
            _consumptionRepository = consumptionRepository;
        }

        public void Sell(Guid tutorId, Guid productId, string customer, string phoneNumber)
        {
            var tutor = _tutorMgr.GetTutor(tutorId);
            var product = _productMgr.Get(productId);
            Purchase purchase;
            Member member = null;
            if (product is MemberProduct)
            {
                member = _memberMgr.Get(phoneNumber);
                if (member == null) throw new MemberNotExistException();
                purchase = tutor.Sell((MemberProduct)product, member);
                _memberMgr.Modify(member);
                foreach (var balance in member.Balances)
                    _balanceMgr.Modify(balance);
            }
            else
            {
                purchase = tutor.Sell((OneTimeExperience)product);
            }

            purchase.GenerateNewIdentity();
            _purchaseRepository.Add(purchase);
            _purchaseRepository.UnitOfWork.Commit();
        }

        public void TakeMemberProduct(Guid tutorId, Guid memberProductId, string memberPhoneNumber)
        {
            var member = _memberMgr.Get(memberPhoneNumber);
            if (member == null) throw new MemberNotExistException();
            var balance = new Balance();
            var consumption = member.Consume(memberProductId, tutorId, out balance);
            _consumptionRepository.Add(consumption);
            _balanceMgr.Modify(balance);
        }

        public void TakeMemberProduct(Guid tutorId, Guid lectureId, string memberPhoneNumber, string lectureDescription)
        {
            var member = _memberMgr.Get(memberPhoneNumber);
            if (member == null) throw new MemberNotExistException();
            var balance = new Balance();
            var session = member.Consume(lectureId, tutorId, lectureDescription, out balance);

            _consumptionRepository.Add(session);
            _balanceMgr.Modify(balance);
        }
    }
}