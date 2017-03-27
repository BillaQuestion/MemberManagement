using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MM.Model
{
    /// <summary>
    /// 课程
    /// </summary>
    [DataContract(IsReference = true)]
    [KnownType(typeof(Product))]
    [KnownType(typeof(MemberProduct))]
    [Serializable]
    public class Lecture : MemberProduct
    {
        /// <summary>
        /// 课程描述
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = base.Validate(validationContext).ToList();
            if(string.IsNullOrEmpty(Description))
                result.Add(new ValidationResult("Description必须赋值！", new string[] { "Description" }));
            return result;
        }

        /// <summary>
        /// 创建课程产品的新卡
        /// </summary>
        protected override MemberCard CreateMemberCart()
        {
            var memberCard = new LectureMemberCard()
            {
                Name = this.Name,
                MediumName = this.Medium.Name,
                TotalCount = this.Count,
                Remainder = this.Count,
                Description = this.Description,
                Product = this,
                ProductId = this.Id
            };
            memberCard.GenerateNewIdentity();


            return memberCard;
        }
    }
}