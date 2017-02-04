using MM.Model;
using MM.Model.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dayi.Data.Domain.Seedwork.Specification;

namespace MM.Business
{
    /// <summary>
    /// 教师的业务类
    /// </summary>
    public class TutorMgr
    {
        ITutorRepository _tutorRepository;
        IProductRepository _productRepository;
        IMemberRepository _memberRepository;
        IPurchaseRepository _purchaseRepository;
        IBalanceRepository _balanceRepository;

        public TutorMgr(ITutorRepository tutorRepository,
            IProductRepository productRepository,
            IMemberRepository memberRepository,
            IPurchaseRepository purchaseRepository,
            IBalanceRepository balanceRepository)
        {
            _tutorRepository = tutorRepository;
            _productRepository = productRepository;
            _memberRepository = memberRepository;
            _purchaseRepository = purchaseRepository;
            _balanceRepository = balanceRepository;
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
            Tutor tutor = _tutorRepository.GetByKey(tutorId);
            var product = _productRepository.GetByKey(productId);
            Purchase purchase = tutor.Sell(product, customer, phoneNumber);
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

            _tutorRepository.UnitOfWork.Commit();
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
