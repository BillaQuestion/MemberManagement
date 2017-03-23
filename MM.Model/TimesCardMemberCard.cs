using MM.Model.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Model
{
    public class TimesCardMemberCard : MemberCard
    {
        /// <summary>
        /// 次卡消费
        /// </summary>
        /// <param name="timesCardProduct">次卡对象</param>
        /// <param name="tutor">教师</param>
        /// <returns>消费记录</returns>
        public Consumption Consume(Tutor tutor)
        {
            if (Remainder <= 0) throw new BalanceNotEnoughException("余额不足！");
            Remainder--;

            Consumption consumption = new Consumption()
            {
                MemberCard = this,
                MemberCardId = this.Id,
                Tutor = tutor,
                TutorId = tutor.Id,
                ConsumeDate = DateTime.Now
            };
            Consumptions.Add(consumption);

            return consumption;
        }
    }
}