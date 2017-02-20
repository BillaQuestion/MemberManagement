using Dayi.Data.Domain.Seedwork;
using System;
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

        /// <summary>
        /// 画布介质
        /// </summary>
        public Medium Medium { get; set; }

        public Guid MediumId { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validateResults = new List<ValidationResult>();

            if (string.IsNullOrEmpty(Name))
                validateResults.Add(new ValidationResult("产品名称必须赋值！", new string[] { "Name" }));
            
            if (Medium == null && MediumId == Guid.Empty)
                validateResults.Add(new ValidationResult("介质必须赋值！", new string[] { "Medium" }));

            return validateResults;
        }
    }
}