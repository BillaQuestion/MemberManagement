using Dayi.Data.Domain.Seedwork;
using MM.Model.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MM.Model
{
    /// <summary>
    /// 会员卡
    /// </summary>
    public abstract class MemberCard : Entity
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 画布介质名称
        /// </summary>
        public string MediumName { get; set; }

        /// <summary>
        /// 总次数
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 购买日期
        /// </summary>
        public DateTime PurchaseDate { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        public int Remainder { get; set; }

        /// <summary>
        /// 会员Id
        /// </summary>
        public Guid MemeberId { get; set; }

        /// <summary>
        /// 会员
        /// </summary>
        public Member Member { get; set; }

        /// <summary>
        /// 销售记录Id
        /// </summary>
        public Guid SellRecordId { get; set; }

        /// <summary>
        /// 销售记录
        /// </summary>
        public SellRecord SellRecord { get; set; }

        /// <summary>
        /// 产品Id
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// 会员产品
        /// </summary>
        public MemberProduct Product { get; set; }

        private HashSet<Consumption> consumptions;
        public ICollection<Consumption> Consumptions
        {
            get
            {
                if (consumptions == null)
                    consumptions = new HashSet<Consumption>();
                return consumptions;
            }
            set
            {
                consumptions = new HashSet<Consumption>(value);
            }
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();
            if (string.IsNullOrEmpty(Name))
                result.Add(new ValidationResult("必须给会员卡名称赋值！",
                    new string[] { "Name" }));
            if (string.IsNullOrEmpty(MediumName))
                result.Add(new ValidationResult("必须给会员卡对象中的介质名称赋值！",
                    new string[] { "MediumName" }));
            if (TotalCount == 0)
                result.Add(new ValidationResult("必须给会员卡对象中的总数量赋值！",
                    new string[] { "TotalCount" }));
            return result; 
        }
    }
}