using Microsoft.AspNetCore.Mvc;
using WorkerManagement.Context;
using WorkerManagement.ViewModels;

namespace WorkerManagement.Controllers
{
    [Route("Worker")]
    public class WorkersController : Controller
    {
        [HttpGet("list", Name = "Worker-list")]
        public IActionResult List()
        {
            using DataContext dbcontext = new DataContext();
            var workers = dbcontext.Workers.ToList();

           var model= workers.Select(w => new WorkerlistViewModel(w.WorkerCode, w.Name, w.Surname, w.FatherName)).ToList();
            return View(model);
        }
       
        
        [HttpGet("add", Name = "Worker-add")]
        public ActionResult Add()
        {
            return View();
        }


        [HttpPost("add", Name = "Worker-add")]
        public ActionResult Add(AddViewModel model)
        {
            using DataContext dbcontext = new DataContext();


            dbcontext.Workers.Add(new Models.Worker
            {
                WorkerCode = model.WorkerCode,
                Name=model.Name,
                Surname=model.Surname,
                Email=model.Email,
                FatherName=model.FatherName
            });
            dbcontext.SaveChanges();
            return RedirectToAction(nameof(List));
        }


    }
}
