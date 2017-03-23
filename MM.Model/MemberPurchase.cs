using System;

namespace MM.Model
{
    public class MemberPurchase : SellRecord
    {
        public Guid MemberId { get; set; }

        public Member Member { get; set; }
    }
}
