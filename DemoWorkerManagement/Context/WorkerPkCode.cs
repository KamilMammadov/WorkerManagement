namespace DemoWorkerManagement.Context
{
    public class WorkerPkCode
    {

        static Random _random = new Random();
        private static string _workerCode;

        public static string WorkerCode
        {
            get
            {
                DataContext dataContext = new DataContext();
                var workers = dataContext.Workers.ToList();

                bool status = true;
                string newCode = "E" + _random.Next(10000, 100000);

                while (status)
                {
                    int lastCode = 0;

                    foreach (var worker in workers)
                    {
                        if (worker.WorkerCode == newCode)
                        {
                            do
                            {
                                newCode = "E" + _random.Next(10000, 100000);

                            } while (worker.WorkerCode != newCode);
                        }
                        lastCode++;

                    }
                    if (lastCode == workers.Count)
                    {
                        status = false;
                    }
                }
                return newCode;
            }
        }
    }
}
