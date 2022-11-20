using DemoWorkerManagement.Context;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace DemoWorkerManagement.Utility
{
    public class FinCodeValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            using DataContext dbcontext = new DataContext();
            var workers = dbcontext.Workers.FirstOrDefault(w => w.FinCode==value.ToString());

         
            if (workers != null)
            {
                return new ValidationResult("FinCode exists");
            }

            Regex regex = new Regex(@"^[A-Z0-9]{7}$");

            if (value != null )
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
