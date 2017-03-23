using MM.Model.Exceptions;
using System;

namespace MM.Model
{
    public class LectureMemberCard : MemberCard
    {
        /// <summary>
        /// 课程描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 课时消费
        /// </summary>
        /// <param name="lectureProduct">课程对象</param>
        /// <param name="tutor">教师</param>
        /// <param name="lectureDescription">授课内容</param>
        /// <returns>消费记录</returns>
        public Consumption Learn(Tutor tutor, string lectureDescription)
        {
            if (Remainder <= 0) throw new BalanceNotEnoughException("余额不足！");
            Remainder--;

            Session session = new Session()
            {
                MemberCard = this,
                MemberCardId = this.Id,
                Tutor = tutor,
                TutorId = tutor.Id,
                Description = lectureDescription,
                ConsumeDate = DateTime.Now
            };
            Consumptions.Add(session);

            return session;
        }
    }
}