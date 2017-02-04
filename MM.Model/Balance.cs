using Dayi.Data.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MM.Model
{
    /// <summary>
    /// 会员卡余额
    /// </summary>
    public class Balance : Entity
    {
        /// <summary>
        /// 会员产品
        /// </summary>
        public MemberProduct MemberProduct { get; set; }

        /// <summary>
        /// 会员产品的Id
        /// </summary>
        public Guid MemberProductId { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        public int Remainder { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();
            if (MemberProduct == null && MemberProductId == Guid.Empty)
                result.Add(new ValidationResult("MemberProduct或MemberProductId必须赋值！", 
                    new string[] { "MemberProduct", "MemberProductId" }));
            return result; 
        }
    }
}