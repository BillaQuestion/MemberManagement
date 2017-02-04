using Dayi.Data.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace MM.Model
{
    /// <summary>
    /// 销售产品
    /// </summary>
    [DataContract(IsReference = true)]
    [Serializable]
    public abstract class Product : Entity
    {
        /// <summary>
        /// 名称
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// 费用
        /// </summary>
        [DataMember]
        public decimal Price { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validateResults = new List<ValidationResult>();

            if (string.IsNullOrEmpty(Name))
                validateResults.Add(new ValidationResult("Name必须赋值！", new string[] { "Name" }));
            
            return validateResults;
        }
    }
}