using Dayi.Data.Domain.Seedwork;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MM.Model
{
    /// <summary>
    /// 销售产品
    /// </summary>
    public abstract class Product : Entity
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 费用
        /// </summary>
        public decimal Price { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validateResults = new List<ValidationResult>();

            if (string.IsNullOrEmpty(Name))
                validateResults.Add(new ValidationResult("产品名称必须赋值！", new string[] { "Name" }));
            
            return validateResults;
        }
    }
}