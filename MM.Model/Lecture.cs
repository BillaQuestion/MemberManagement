using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Model
{
    /// <summary>
    /// 课程
    /// </summary>
    public class Lecture : MemberProduct
    {
        /// <summary>
        /// 课程描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 学时
        /// </summary>
        public int Hourse { get; set; }
    }
}