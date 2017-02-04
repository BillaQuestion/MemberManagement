using Dayi.Data.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MM.Model
{
    /// <summary>
    /// 消费
    /// </summary>
    public class Consumption : Entity
    {
        /// <summary>
        /// 会员卡
        /// </summary>
        public MemberProduct MemberProduct { get; set; }

        /// <summary>
        /// 购买日期
        /// </summary>
        public DateTime ConsumeDate { get; }

        /// <summary>
        /// 教师
        /// </summary>
        public Tutor Tutor { get; set; }

        /// <summary>
        /// 教师的Id
        /// </summary>
        public Guid TutorId { get; set; }

        public Consumption()
        {
            ConsumeDate = DateTime.Now;
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();
            if (MemberProduct == null)
                result.Add(new ValidationResult("MemberProduct必须赋值！", new string[] { "MemberProduct" }));
            if (Tutor == null)
                result.Add(new ValidationResult("Tutor必须赋值！", new string[] { "Tutor" }));
            return result;
        }
    }
}