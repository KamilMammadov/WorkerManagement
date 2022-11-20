namespace DemoWorkerManagement.ViewModels
{
    public class WorkerlistViewModel
    {
        public string WorkerCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public bool isDeleted { get; set; }



        public WorkerlistViewModel(string workercode, string name, string surname, string fatherName, bool isDeleted)
        {
            WorkerCode = workercode;
            Name = name;
            Surname = surname;
            FatherName = fatherName;
            this.isDeleted = isDeleted;
        }
    }
}
