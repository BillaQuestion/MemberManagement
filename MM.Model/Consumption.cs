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
        /// 会员卡Id
        /// </summary>
        public Guid MemberCardId { get; set; }

        /// <summary>
        /// 会员卡
        /// </summary>
        public MemberCard MemberCard { get; set; }

        /// <summary>
        /// 购买日期
        /// </summary>
        public DateTime ConsumeDate { get; set; }

        /// <summary>
        /// 教师
        /// </summary>
        public Tutor Tutor { get; set; }

        /// <summary>
        /// 教师的Id
        /// </summary>
        public Guid TutorId { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();
            if (MemberCard == null && MemberCardId == Guid.Empty)
                result.Add(new ValidationResult("会员卡必须赋值！",
                    new string[] { "MemberCard", "MemberCardId" }));
            if (Tutor == null && TutorId == Guid.Empty)
                result.Add(new ValidationResult("教师必须赋值！",
                    new string[] { "Tutor", "TutorId" }));
            return result;
        }
    }
}