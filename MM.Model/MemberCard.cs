using Dayi.Data.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MM.Model
{
    /// <summary>
    /// 会员卡
    /// </summary>
    public class MemberCard : Entity
    {
        /// <summary>
        /// 会员产品
        /// </summary>
        public MemberProduct Product { get; set; }

        /// <summary>
        /// 会员产品的Id
        /// </summary>
        public Guid MemberProductId { get; set; }

        /// <summary>
        /// 画布介质名称
        /// </summary>
        public string MediumName { get; set; }

        /// <summary>
        /// 总次数
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 购买日期
        /// </summary>
        public DateTime PurchaseDate { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        public int Remainder { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();
            if (Product == null && MemberProductId == Guid.Empty)
                result.Add(new ValidationResult("必须给会员卡对象中的产品赋值！", 
                    new string[] { "MemberProduct", "MemberProductId" }));
            if (string.IsNullOrEmpty(MediumName))
                result.Add(new ValidationResult("必须给会员卡对象中的介质名称赋值！",
                    new string[] { "MediumName" }));
            if (Count == 0)
                result.Add(new ValidationResult("必须给会员卡对象中的总数量赋值！",
                    new string[] { "Count" }));
            return result; 
        }
    }
}