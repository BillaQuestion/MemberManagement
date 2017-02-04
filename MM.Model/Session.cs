using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MM.Model
{
    public class Session : Consumption
    {
        public string Description { get; set; }
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = base.Validate(validationContext).ToList();
            if (string.IsNullOrEmpty(Description))
                result.Add(new ValidationResult("Description必须赋值！", new string[] { "Description" }));
            return result;
        }
    }
}