using MM.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dayi.Data.Domain.Seedwork;
using System.ComponentModel.DataAnnotations;

namespace MM.Model
{
    public class Tutor : Entity
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public string ContactNumber { get; set; }

        public string Address { get; set; }

        /// <summary>
        /// 是否是管理员
        /// </summary>
        public bool IsManager { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();
            if (string.IsNullOrEmpty(ContactNumber))
                result.Add(new ValidationResult("ContactNumber必须赋值！", new string[] { "ContactNumber" }));
            return result;
        }
    }
}