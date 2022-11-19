namespace WorkerManagement.ViewModels
{
    public class AddViewModel
    {
        public string WorkerCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
       

        public AddViewModel(string name, string surname, string fathername, string email, string workercode)
        {
            WorkerCode = workercode;
            Name = name;
            Surname = surname;
            FatherName = fathername;
            Email = email;
       
        }

        public AddViewModel()
        {

        }
    }
}
