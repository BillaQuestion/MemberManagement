using MM.Model;
using MM.Model.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dayi.Data.Domain.Seedwork.Specification;
using MM.Business.Exceptions;
using System.Security.Principal;
using System.Security.Cryptography;
using System.Threading;
using System.Transactions;
using MM.Model.Exceptions;

namespace MM.Business
{
    /// <summary>
    /// 教师的业务类
    /// </summary>
    public class StudioService
    {
        ITutorMgr _tutorMgr;
        IProductMgr _productMgr;
        IMemberMgr _memberMgr;
        IPurchaseMgr _purchaseMgr;
        IConsumptionMgr _consumptionMgr;

        public StudioService(ITutorMgr tutorMgr,
            IProductMgr productMgr,
            IMemberMgr memberMgr,
            IPurchaseMgr purchaseMgr,
            IConsumptionMgr consumptionMgr)
        {
            _tutorMgr = tutorMgr;
            _productMgr = productMgr;
            _memberMgr = memberMgr;
            _purchaseMgr = purchaseMgr;
            _consumptionMgr = consumptionMgr;
        }

        /// <summary>
        /// 销售产品
        /// </summary>
        /// <param name="tutorId">教师Id</param>
        /// <param name="productId">产品Id</param>
        /// <param name="customerName">顾客姓名</param>
        /// <param name="phoneNumber">顾客手机号码</param>
        public void Sell(Guid tutorId, Guid productId, string customerName, string phoneNumber)
        {
            var tutor = _tutorMgr.GetById(tutorId);
            var product = _productMgr.GetById(productId);
            //if (product is OneTimeExperience)
            //    throw new 

            using (TransactionScope scope = new TransactionScope())
            {
                Purchase purchase;
                Member member = null;
                member = _memberMgr.FindByPhoneNumber(phoneNumber);
                if (member == null)
                {

                }
                purchase = tutor.Sell((MemberProduct)product, member);
                _purchaseMgr.Save(purchase);
                if (member != null)
                {
                    _memberMgr.Save(member);
                }
                scope.Complete();
            }
        }

        public void Sell(Guid tutorId, Guid productId)
        {
            var tutor = _tutorMgr.GetById(tutorId);
            var product = _productMgr.GetById(productId);
            if (product is MemberProduct)
                throw new ArgumentException("调用方法错误：需要会员信息");

            using (TransactionScope scope = new TransactionScope())
            {
                Purchase purchase;
                Member member = null;
                purchase = tutor.Sell((OneTimeExperience)product);

                _purchaseMgr.Save(purchase);
                if (member != null)
                {
                    _memberMgr.Save(member);
                }
                scope.Complete();
            }
        }

        //public void ModifyMember(Member member)
        //{
        //    _memberRepository.Modify(member);

        //    _memberRepository.UnitOfWork.Commit();
        //}

        public void TakeMemberProduct(Guid tutorId, Guid memberProductId, string memberPhoneNumber)
        {
            TakeMemberProduct(tutorId, memberProductId, "", memberPhoneNumber);
        }

        public void TakeMemberProduct(Guid tutorId, Guid lectureId, string lectureDescription, string memberPhoneNumber)
        {
            var member = _memberMgr.FindByPhoneNumber(memberPhoneNumber);
            if (member == null)
                throw new MemberNotExistException("会员不存在！");

            var tutor = _tutorMgr.GetById(tutorId);
            if (tutor == null)
                throw new TutorNotExistException("教师不存在！");

            var product = _productMgr.GetById(lectureId);
            if (product == null)
                throw new ProductNotExistException("产品不存在!");
            if (product is OneTimeExperience)
                throw new ArgumentException("一次性体验产品不能进行会员消费！");

            using (TransactionScope scope = new TransactionScope())
            {
                Consumption consumption;
                if (product is TimesCard)
                    consumption = member.Consume((TimesCard)product, tutor);
                else
                    consumption = member.Consume((Lecture)product, tutor, lectureDescription);

                _consumptionMgr.Save(consumption);
                _memberMgr.Save(member);

                scope.Complete();
            }
        }
    }
}
