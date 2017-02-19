﻿using Dayi.Data.Domain.Seedwork;
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
        /// 会员Id
        /// </summary>
        public Guid MemberId { get; set; }

        /// <summary>
        /// 会员
        /// </summary>
        public Member Member { get; set; }
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

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();
            if (MemberProduct == null && MemberProductId == Guid.Empty)
                result.Add(new ValidationResult("产品必须赋值！",
                    new string[] { "MemberProduct", "MemberProductId" }));
            if (Tutor == null && TutorId == Guid.Empty)
                result.Add(new ValidationResult("教师必须赋值！",
                    new string[] { "Tutor", "TutorId" }));
            return result;
        }
    }
}