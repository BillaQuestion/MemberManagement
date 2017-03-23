using System;

namespace MM.Model
{
    public class TimesCard : MemberProduct
    {
        protected override MemberCard CreateMemberCart(Member member, SellRecord sellRecord)
        {
            var memberCard = new TimesCardMemberCard()
            {
                Name = this.Name,
                MediumName = this.Medium.Name,
                TotalCount = this.Count,
                Remainder = this.Count,
                SellRecord = sellRecord,
                Product = this,
                ProductId = this.Id,
                PurchaseDate = DateTime.Now
            };

            return memberCard;
        }
    }
}