using DemoWorkerManagement.Utility;
using System.ComponentModel.DataAnnotations;

namespace DemoWorkerManagement.ViewModels
{
    public class AddViewModel
    {

        [Required]
        [RegularExpression(@"[A-Za-z]{3,20}", ErrorMessage = "please enter true values")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z]{3,20}", ErrorMessage = "please enter true values")]

        public string Surname { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z]{3,20}", ErrorMessage = "please enter true values")]

        public string FatherName { get; set; }
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [FinCodeValidation]
        public string FinCode { get; set; }

        //public AddViewModel(string name, string surname, string fathername, string email, string workercode)
        //{
        //    WorkerCode = workercode;
        //    Name = name;
        //    Surname = surname;
        //    FatherName = fathername;
        //    Email = email;

        //}

        //public AddViewModel()
        //{

        //}
    }
}
