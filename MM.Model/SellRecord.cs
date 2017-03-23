using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Dayi.Data.Domain.Seedwork;


namespace MM.Model
{
    /// <summary>
    /// 购买
    /// </summary>
    public class SellRecord : Entity
    {
        #region Properties

        /// <summary>
        /// 购买产品
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// 购买产品的Id
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// 费用，需要记录而不是返回product.Price，因为product的Price会变化
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 购买日期
        /// </summary>
        public DateTime SellDate { get; set; }

        /// <summary>
        /// 经手教师
        /// </summary>
        public Tutor Tutor { get; set; }

        /// <summary>
        /// 经手教师的Id
        /// </summary>
        public Guid TutorId { get; set; }
        #endregion

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();

            if (Product == null)
                result.Add(new ValidationResult("Product必须赋值！", new string[] { "Product" }));

            return result;
        }
    }
}