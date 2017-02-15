using MM.Model;
using MM.Model.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dayi.Data.Domain.Seedwork.Specification;
using MM.Business.Exceptions;

namespace MM.Business
{
    /// <summary>
    /// 教师的业务类
    /// </summary>
    public class TutorMgr
    {
        protected ITutorRepository _tutorRepository;
        protected IProductRepository _productRepository;
        protected IMemberRepository _memberRepository;
        protected IPurchaseRepository _purchaseRepository;
        protected IBalanceRepository _balanceRepository;
        protected IConsumptionRepository _consumptionRepository;

        public TutorMgr(ITutorRepository tutorRepository,
            IProductRepository productRepository,
            IMemberRepository memberRepository,
            IPurchaseRepository purchaseRepository,
            IBalanceRepository balanceRepository,
            IConsumptionRepository consumptionRepository)
        {
            _tutorRepository = tutorRepository;
            _productRepository = productRepository;
            _memberRepository = memberRepository;
            _purchaseRepository = purchaseRepository;
            _balanceRepository = balanceRepository;
            _consumptionRepository = consumptionRepository;
        }

        /// <summary>
        /// 销售产品
        /// </summary>
        /// <param name="tutorId">教师Id</param>
        /// <param name="productId">产品Id</param>
        /// <param name="customer">顾客姓名</param>
        /// <param name="phoneNumber">顾客手机号码</param>
        public void Sell(Guid tutorId, Guid productId, string customer, string phoneNumber)
        {
            var tutor = _tutorRepository.GetByKey(tutorId);
            var product = _productRepository.GetByKey(productId);
            var purchase = tutor.Sell(product, customer, phoneNumber);
            purchase.GenerateNewIdentity();
            _purchaseRepository.Add(purchase);

            if (product is MemberProduct)
            {
                var member = FindMemberByPhoneNumber(phoneNumber);
                if (member == null)
                {
                    member = new Member()
                    {
                        Name = customer,
                        PhoneNumber = phoneNumber
                    };
                    _memberRepository.Add(member);
                }
                var balance = member.Buy(purchase);
                SaveBalance(balance);
            }

            _purchaseRepository.UnitOfWork.Commit();
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

        public void TakeMemberProduct(Guid tutorId, Guid memberProductId, string memberPhoneNumber)
        {
            var member = FindMemberByPhoneNumber(memberPhoneNumber);
            if (member == null) throw new MemberNotExistException();
            var balance = new Balance();
            var consumption = member.Consume(memberProductId, tutorId, out balance);
            _consumptionRepository.Add(consumption);
            if (balance.Remainder == 0)
                _balanceRepository.Remove(balance);
            else
                SaveBalance(balance);

            _consumptionRepository.UnitOfWork.Commit();
        }

        public void TakeMemberProduct(Guid tutorId, Guid lectureId, string lectureDescription, string memberPhoneNumber)
        {
            var member = FindMemberByPhoneNumber(memberPhoneNumber);
            if (member == null) throw new MemberNotExistException();
            var balance = new Balance();
            var session = member.Consume(lectureId, tutorId, lectureDescription, out balance);

            _consumptionRepository.Add(session);
            if (balance.Remainder == 0)
                _balanceRepository.Remove(balance);
            else
                SaveBalance(balance);

            _consumptionRepository.UnitOfWork.Commit();
        }

        #region 私有方法

        /// <summary>
        /// 根据手机号码查找会员
        /// </summary>
        /// <param name="phoneNumber">手机号码</param>
        /// <returns>会员对象</returns>
        private Member FindMemberByPhoneNumber(string phoneNumber)
        {
            ISpecification<Member> spec = new DirectSpecification<Member>(m => m.PhoneNumber == phoneNumber);
            return _memberRepository.FindBySpecification(spec).FirstOrDefault();
        }

        /// <summary>
        /// 保存会员余额
        /// </summary>
        /// <param name="balance">余额对象</param>
        private void SaveBalance(Balance balance)
        {
            if (balance.IsTransient())
                _balanceRepository.Add(balance);
            else
                _balanceRepository.Modify(balance);
        }
        #endregion
    }
}
