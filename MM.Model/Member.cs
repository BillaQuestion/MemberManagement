using Dayi.Data.Domain.Seedwork;
using MM.Model.Enums;
using MM.Model.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MM.Model
{
    public class Member : Entity
    {
        private HashSet<MemberCard> _memberCards;

        #region Properties
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public Gender Gender { get; set; }

        public string Address { get; set; }

        /// <summary>
        /// 会员卡
        /// </summary>  
        public ICollection<MemberCard> MemberCards
        {
            get
            {
                if (_memberCards == null)
                    _memberCards = new HashSet<MemberCard>();
                return _memberCards;
            }
            set
            {
                _memberCards = new HashSet<MemberCard>(value);
            }
        }
        #endregion

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();
            if (string.IsNullOrEmpty(PhoneNumber))
                result.Add(new ValidationResult("PhoneNumber必须赋值！", new string[] { "PhoneNumber" }));
            return result;
        }
    }
}
