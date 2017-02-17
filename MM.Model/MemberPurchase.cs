using System;

namespace MM.Model
{
    public class MemberPurchase : Purchase
    {
        public Guid MemberId { get; set; }

        public Member Member { get; set; }
    }
}
