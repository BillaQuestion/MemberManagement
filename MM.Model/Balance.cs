using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Dayi.Data.Domain.Seedwork;

namespace MM.Model
{
    /// <summary>
    /// 会员卡余额
    /// </summary>
    public class Balance : Entity
    {
        /// <summary>
        /// 会员卡
        /// </summary>
        public MemberProduct MemberProduct { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        public int Remainder { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();
            if (MemberProduct == null)
                result.Add(new ValidationResult("MemberProduct必须赋值！", new string[] { "MemberProduct" }));
            return result; 
        }
    }
}