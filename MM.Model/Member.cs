using MM.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MM.Model.Exceptions;
using Dayi.Data.Domain.Seedwork;
using System.ComponentModel.DataAnnotations;

namespace MM.Model
{
    public class Member : Entity
    {
        private HashSet<Balance> _balances;

        #region Properties
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public Gender Gender { get; set; }

        public string Address { get; set; }

        /// <summary>
        /// 会员卡余额
        /// </summary>  
        public ICollection<Balance> Balances
        {
            get
            {
                if (_balances == null)
                    _balances = new HashSet<Balance>();
                return _balances;
            }
        }
        #endregion

        public Member(Balance balance)
        {
            _balances = new HashSet<Balance>();
            _purchaseRecords = new HashSet<MemberPurchase>();
            _consumeRecords = new HashSet<Consumption>();
            _balances.Add(balance);
        }

        /// <summary>
        /// 购买记录
        /// </summary>
        public ICollection<MemberPurchase> PurchaseRecords
        {
            get
            {
                if (_purchaseRecords == null)
                    _purchaseRecords = new HashSet<MemberPurchase>();
                return _purchaseRecords;
            }
        }

        /// <summary>
        /// 次卡消费
        /// </summary>
        /// <param name="timesCardProduct">次卡对象</param>
        /// <param name="tutor">教师</param>
        /// <returns>消费记录</returns>
        public Consumption Consume(TimesCard timesCardProduct, Tutor tutor)
        {
            var balance = _balances.FirstOrDefault(x => x.MemberProductId == timesCardProduct.Id);
            if (balance == null) throw new BalanceNotEnoughException("余额不足！");
            balance.Remainder--;
            if (balance.Remainder == 0) _balances.Remove(balance);

            Consumption consumption = new Consumption()
            {
                Member = this,
                MemberId = this.Id,
                MemberProduct = timesCardProduct,
                MemberProductId = timesCardProduct.Id,
                Tutor = tutor,
                TutorId = tutor.Id,
                ConsumeDate = DateTime.Now
            };

            return consumption;
        }

        /// <summary>
        /// 课时消费
        /// </summary>
        /// <param name="lectureProduct">课程对象</param>
        /// <param name="tutor">教师</param>
        /// <param name="lectureDescription">授课内容</param>
        /// <returns>消费记录</returns>
        public Consumption Consume(Lecture lectureProduct, Tutor tutor, string lectureDescription)
        {
            var balance = _balances.FirstOrDefault(x => x.MemberProductId == lectureProduct.Id);
            if (balance == null) throw new BalanceNotEnoughException("余额不足！");
            balance.Remainder--;
            if (balance.Remainder == 0) _balances.Remove(balance);

            Session session = new Session()
            {
                Member = this,
                MemberId = this.Id,
                MemberProduct = lectureProduct,
                MemberProductId = lectureProduct.Id,
                Tutor = tutor,
                TutorId = tutor.Id,
                Description = lectureDescription,
                ConsumeDate = DateTime.Now
            };

            return session;
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();
            if (string.IsNullOrEmpty(PhoneNumber))
                result.Add(new ValidationResult("PhoneNumber必须赋值！", new string[] { "PhoneNumber" }));
            return result;
        }


        #endregion
    }
}
