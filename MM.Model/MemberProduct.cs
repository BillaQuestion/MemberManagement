using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Dayi.Data.Domain.Seedwork;
using System.ComponentModel.DataAnnotations;

namespace MM.Model
{
    public abstract class MemberProduct : Product
    {
        public int Count { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = base.Validate(validationContext).ToList();
            if (Count == 0)
                result.Add(new ValidationResult("次数必须赋值！", new string[] { "Count" }));
            return result;
        }


        /// <summary>
        /// 向会员销售
        /// </summary>
        /// <returns>购买记录</returns>
        public SellRecord Sell(Tutor tutor, Member member, out MemberCard memberCard)
        {
            // 1、新建一个购买记录
            SellRecord sellRecord = new SellRecord()
            {
                Product = this,
                ProductId = this.Id,
                Price = this.Price,
                Tutor = tutor,
                TutorId = tutor.Id,
                SellDate = DateTime.Now
            };

            memberCard = CreateMemberCart(member, sellRecord);
            member.MemberCards.Add(memberCard);

            return sellRecord;
        }

        protected abstract MemberCard CreateMemberCart(Member member, SellRecord sellRecord);
    }
}