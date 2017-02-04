using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Model
{
    /// <summary>
    /// 销售产品
    /// </summary>
    public class Product
    {
        /// <summary>
        /// 名称
        /// </summary>
        #region
        public string Name { get; set; }

        /// <summary>
        /// 费用
        /// </summary>
        public decimal Cost { get; set; }
        #endregion
    }
}