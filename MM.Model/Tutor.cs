using MM.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Model
{
    public class Tutor
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public string ContactNumber { get; set; }

        public string Address { get; set; }

        /// <summary>
        /// 是否是管理员
        /// </summary>
        public bool IsManager { get; set; }
    }
}