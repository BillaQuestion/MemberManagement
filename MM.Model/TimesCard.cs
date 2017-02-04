using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;

namespace MM.Model
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(Product))]
    [Serializable]
    public class TimesCard : MemberProduct
    {
        /// <summary>
        /// 画布介质
        /// </summary>
        [DataMember]
        public Medium Medium { get; set; }

        [DataMember]
        public Guid MediumId { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = base.Validate(validationContext).ToList();
            if (Medium == null)
                result.Add(new ValidationResult("Medium必须赋值！", new string[] { "Medium" }));
            return result;
        }
    }
}