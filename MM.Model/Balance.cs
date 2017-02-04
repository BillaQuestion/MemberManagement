using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Model
{
    /// <summary>
    /// 会员卡余额
    /// </summary>
    public class Balance
    {
        /// <summary>
        /// 会员卡
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        public int Remainder { get; set; }
    }
}