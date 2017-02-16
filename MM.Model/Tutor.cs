using MM.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dayi.Data.Domain.Seedwork;
using System.ComponentModel.DataAnnotations;

namespace MM.Model
{
    public class Tutor : Entity
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        /// <summary>
        /// 是否是管理员
        /// </summary>
        public bool IsManager { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();
            if (string.IsNullOrEmpty(PhoneNumber))
                result.Add(new ValidationResult("ContactNumber必须赋值！", new string[] { "ContactNumber" }));
            return result;
        }

        public Purchase Sell(Product product, string phoneNumber)
        {
            Purchase purchase = new Model.Purchase()
            {
                PhoneNumber = phoneNumber,
                Product = product,
                Tutor = this,
            };
            return purchase;
        }

        /// <summary>
        /// 销售产品
        /// </summary>
        /// <param name="product">所销售产品</param>
        /// <param name="customer">顾客姓名</param>
        /// <param name="phoneNumber">顾客手机号码</param>
        /// <returns>购买记录</returns>
        public Purchase Sell(Product product, string customer, string phoneNumber)
        {
            Purchase purchase = new Model.Purchase()
            {
                CustomerName = customer,
                PhoneNumber = phoneNumber,
                Product = product,
                Tutor = this,
                PurchaseDate = DateTime.Now
            };
            return purchase;
        }

    }
}