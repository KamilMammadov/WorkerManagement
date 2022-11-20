using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace DemoWorkerManagement.Utility
{
    public class FinCodeValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
           Regex regex = new Regex(@"^[A-Z0-9]{7}$");

            if (value != null)
            {
                string FinCode = value.ToString();
                if (regex.IsMatch(FinCode))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("Error");
        }
    }
}
