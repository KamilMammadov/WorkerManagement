namespace DemoWorkerManagement.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string WorkerCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string FatherName { get; set; }
        public string FinCode { get; set; }
        public bool IsDeleted { get; set; }
    }
}
