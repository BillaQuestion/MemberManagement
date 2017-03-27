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
        public SellRecord Sell(Tutor tutor, Member member)
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

            // 产生一张新卡
            MemberCard newMemberCard = CreateMemberCart();

            // 卡中写入会员及销售信息
            newMemberCard.SellRecord = sellRecord;
            newMemberCard.PurchaseDate = DateTime.Now;
            newMemberCard.Member = member;

            // 会员的卡集中增加此卡
            member.MemberCards.Add(newMemberCard);

            return sellRecord;
        }

        /// <summary>
        /// 创建产品的新卡
        /// </summary>
        protected abstract MemberCard CreateMemberCart();
    }
}