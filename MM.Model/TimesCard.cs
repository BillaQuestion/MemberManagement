namespace MM.Model
{
    public class TimesCard : MemberProduct
    {
        /// <summary>
        /// 创建次卡产品的新卡
        /// </summary>
        protected override MemberCard CreateMemberCart()
        {
            var memberCard = new TimesCardMemberCard()
            {
                Name = this.Name,
                MediumName = this.Medium.Name,
                TotalCount = this.Count,
                Remainder = this.Count,
                Product = this,
                ProductId = this.Id
            };
            memberCard.GenerateNewIdentity();

            return memberCard;
        }
    }
}