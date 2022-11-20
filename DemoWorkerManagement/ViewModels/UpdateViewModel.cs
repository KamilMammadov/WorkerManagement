using System.ComponentModel.DataAnnotations;

namespace DemoWorkerManagement.ViewModels
{
    public class UpdateViewModel
    {
        public string WorkerCode { get; set; }
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

        public UpdateViewModel()
        {
                
        }
        public UpdateViewModel(string workerCode, string name, string surname, string fatherName, string email)
        {
            WorkerCode = workerCode;
            Name = name;
            Surname = surname;
            FatherName = fatherName;
            Email = email;
        }
    }
}
