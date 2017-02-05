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
        /// 会员产品
        /// </summary>
        public MemberProduct MemberProduct { get; set; }

        /// <summary>
        /// 会员产品的Id
        /// </summary>
        public Guid MemberProductId { get; set; }

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

        public Session ToSession(string description)
        {
            Session session = new Session()
            {
                Description = description,
                Id = this.Id,
                MemberProduct = this.MemberProduct,
                MemberProductId = this.MemberProductId,
                Tutor = this.Tutor,
                TutorId = this.TutorId
            };
            return session;
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();
            if (MemberProduct == null && MemberProductId == Guid.Empty)
                result.Add(new ValidationResult("MemberProduct或MemberProductId必须赋值！",
                    new string[] { "MemberProduct", "MemberProductId" }));
            if (Tutor == null && TutorId == Guid.Empty)
                result.Add(new ValidationResult("Tutor或TutorId必须赋值！",
                    new string[] { "Tutor", "TutorId" }));
            return result;
        }
    }
}