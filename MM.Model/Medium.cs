using Dayi.Data.Domain.Seedwork;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MM.Model
{
    public class Medium : Entity
    {
        public string Name { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validateResults = new List<ValidationResult>();

            if (string.IsNullOrEmpty(Name))
                validateResults.Add(new ValidationResult("Name必须赋值！", new string[] { "Name" }));

            return validateResults;
        }
    }
}