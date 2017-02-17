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
    public class Purchase : Entity
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
        /// 费用
        /// </summary>
        public decimal Price
        {
            get
            {
                return Product.Price;
            }

        }

        /// <summary>
        /// 购买日期
        /// </summary>
        public DateTime PurchaseDate { get; set; }

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