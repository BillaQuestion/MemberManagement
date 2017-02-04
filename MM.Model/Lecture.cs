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
    }
}