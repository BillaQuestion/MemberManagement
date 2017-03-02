using Dayi.Data.Domain.Seedwork;
using MM.Model.Enums;
using MM.Model.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MM.Model
{
    public class Member : Entity
    {
        private HashSet<MemberCard> _memberCards;

        #region Properties
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public Gender Gender { get; set; }

        public string Address { get; set; }

        /// <summary>
        /// 会员卡
        /// </summary>  
        public ICollection<MemberCard> MemberCards
        {
            get
            {
                if (_memberCards == null)
                    _memberCards = new HashSet<MemberCard>();
                return _memberCards;
            }
            set
            {
                _memberCards = new HashSet<MemberCard>(value);
            }
        }
        #endregion

        /// <summary>
        /// 次卡消费
        /// </summary>
        /// <param name="timesCardProduct">次卡对象</param>
        /// <param name="tutor">教师</param>
        /// <returns>消费记录</returns>
        public Consumption Consume(TimesCard timesCardProduct, Tutor tutor)
        {
            var balance = _memberCards.FirstOrDefault(x => x.MemberProductId == timesCardProduct.Id);
            if (balance == null) throw new BalanceNotEnoughException("余额不足！");
            balance.Remainder--;
            if (balance.Remainder == 0) _memberCards.Remove(balance);

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
            var balance = _memberCards.FirstOrDefault(x => x.MemberProductId == lectureProduct.Id);
            if (balance == null) throw new BalanceNotEnoughException("余额不足！");
            balance.Remainder--;
            if (balance.Remainder == 0) _memberCards.Remove(balance);

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
    }
}
