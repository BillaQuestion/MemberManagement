using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Model
{
    /// <summary>
    /// 购买
    /// </summary>
    public class Purchase
    {
        /// <summary>
        /// 顾客姓名
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 购买产品
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// 费用
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 购买日期
        /// </summary>
        public DateTime PurchaseDate { get; set; }

        /// <summary>
        /// 经手人
        /// </summary>
        public string Handler { get; set; }
    }
}