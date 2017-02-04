using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Model
{
    /// <summary>
    /// 消费
    /// </summary>
    public class Consumption
    {
        /// <summary>
        /// 会员卡
        /// </summary>
        public MemberProduct MemberProduct { get; set; }

        /// <summary>
        /// 购买日期
        /// </summary>
        public DateTime ConsumeDate { get; set; }

        /// <summary>
        /// 教师
        /// </summary>
        public Tutor Tutor { get; set; }
    }
}