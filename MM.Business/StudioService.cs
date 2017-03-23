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
using MM.Model.Enums;

namespace MM.Business
{
    /// <summary>
    /// 教师的业务类
    /// </summary>
    public class StudioService : IAuthenticator, IStudioService
    {
        ITutorMgr _tutorMgr;
        IProductMgr _productMgr;
        IMemberMgr _memberMgr;
        ISellRecordMgr _purchaseMgr;
        IConsumptionMgr _consumptionMgr;
        IMemberCardMgr _memberCardMgr;

        public StudioService(ITutorMgr tutorMgr,
            IProductMgr productMgr,
            IMemberMgr memberMgr,
            ISellRecordMgr purchaseMgr,
            IConsumptionMgr consumptionMgr,
            IMemberCardMgr memberCardMgr)
        {
            _tutorMgr = tutorMgr;
            _productMgr = productMgr;
            _memberMgr = memberMgr;
            _purchaseMgr = purchaseMgr;
            _consumptionMgr = consumptionMgr;
            _memberCardMgr = memberCardMgr;
        }

        /// <summary>
        /// 根据用户名和口令对用户进行认证。
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">口令</param>
        /// <returns>用户通过认证，则返回true；否则返回false。</returns>
        bool IAuthenticator.Authenticate(string username, string password)
        {
            bool authenticated = false;
            Tutor tutor = _tutorMgr.GetByName(username);
            if (tutor != null && tutor.Authenticate(password))
            {
                authenticated = true;
                IIdentity identity = new GenericIdentity(username);
                List<string> roles = new List<string>();
                if (tutor.IsManager) roles.Add("Administrator");
                IPrincipal principal = new GenericPrincipal(identity, roles.ToArray());
                Thread.CurrentPrincipal = principal;
            }

            //将验证结果返回
            return authenticated;
        }

        /// <summary>
        /// 销售产品
        /// </summary>
        /// <param name="tutorName">教师姓名</param>
        /// <param name="productId">产品Id</param>
        /// <param name="customerName">顾客姓名</param>
        /// <param name="phoneNumber">顾客手机号码</param>
        public void Sell(string tutorName, Guid productId, string customerName, string phoneNumber)
        {
            var tutor = _tutorMgr.GetByName(tutorName);
            var product = _productMgr.GetById(productId);
            //if (product is OneTimeExperience)
            //    throw new 

            using (TransactionScope scope = new TransactionScope())
            {
                SellRecord purchase;
                Member member = null;
                if (product is MemberProduct)
                {
                    member = _memberMgr.GetByPhoneNumber(phoneNumber);
                    if (member == null)
                    {
                        member = new Member()
                        {
                            Name = customerName,
                            PhoneNumber = phoneNumber
                        };
                    }
                    MemberCard memberCard;
                    purchase = ((MemberProduct)product).Sell(tutor, member, out memberCard);
                    _memberCardMgr.Save(memberCard);
                    _memberMgr.Save(member);
                    _purchaseMgr.Save(purchase);
                }
                scope.Complete();
            }
        }

        /// <summary>
        /// 销售产品
        /// </summary>
        /// <param name="tutorName">教师姓名</param>
        /// <param name="productId">产品Id</param>
        void IStudioService.Sell(string tutorName, Guid productId)
        {
            var tutor = _tutorMgr.GetByName(tutorName);
            var product = _productMgr.GetById(productId);
            if (product is MemberProduct)
                throw new ArgumentException("调用方法错误：需要会员信息");

            using (TransactionScope scope = new TransactionScope())
            {
                SellRecord purchase;
                purchase = ((OneTimeExperience)product).Sell(tutor);
                _purchaseMgr.Save(purchase);
                scope.Complete();
            }
        }

        /// <summary>
        /// 消费次卡产品
        /// </summary>
        /// <param name="tutorId">教师Id</param>
        /// <param name="timesCardMemberCardId">次卡产品Id</param>
        void IStudioService.TakeMemberProduct(Guid tutorId, Guid timesCardMemberCardId)
        {
            var memberCard = _memberCardMgr.GetById(timesCardMemberCardId);
            if (memberCard == null)
                throw new MemberCardNotExistException(string.Format("会员卡[{0}]不存在！", timesCardMemberCardId));

            var tutor = _tutorMgr.GetById(tutorId);
            if (tutor == null)
                throw new TutorNotExistException("教师不存在！");

            using (TransactionScope scope = new TransactionScope())
            {
                Consumption consumption = (memberCard as TimesCardMemberCard).Consume(tutor);

                _consumptionMgr.Save(consumption);
                _memberCardMgr.Save(memberCard);

                scope.Complete();
            }
        }

        /// <summary>
        /// 消费会员产品
        /// </summary>
        /// <param name="tutorId">教师Id</param>
        /// <param name="lectureMemberCardId">课程会员卡Id</param>
        /// <param name="lectureDescription">授课内容说明</param>
        void IStudioService.TakeMemberProduct(Guid tutorId, Guid lectureMemberCardId, string lectureDescription)
        {
            var memberCard = _memberCardMgr.GetById(lectureMemberCardId);
            if (memberCard == null)
                throw new MemberCardNotExistException(string.Format("会员卡[{0}]不存在！", lectureMemberCardId));

            var tutor = _tutorMgr.GetById(tutorId);
            if (tutor == null)
                throw new TutorNotExistException("教师不存在！");

            using (TransactionScope scope = new TransactionScope())
            {
                Consumption consumption = (memberCard as LectureMemberCard).Learn(tutor, lectureDescription);

                _consumptionMgr.Save(consumption);
                _memberCardMgr.Save(memberCard);

                scope.Complete();
            }
        }

        /// <summary>
        /// 获取系统中的所有产品
        /// </summary>
        /// <returns></returns>
        IEnumerable<Product> IStudioService.GetAllProducts()
        {
            return _productMgr.GetAll();
        }
    }
}
