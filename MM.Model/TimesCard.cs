using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Model
{
    public class TimesCard : Product
    {
        /// <summary>
        /// 画布介质
        /// </summary>
        public string Media { get; set; }

        /// <summary>
        /// 次数
        /// </summary>
        public int CountOfMedia { get; set; }
    }
}