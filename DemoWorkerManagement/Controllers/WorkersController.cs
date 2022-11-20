using DemoWorkerManagement.Context;
using DemoWorkerManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using DemoWorkerManagement.ViewModels;

namespace DemoWorkerManagement.Controllers
{
    [Route("Worker")]
    public class WorkersController : Controller
    {
        [HttpGet("list", Name = "Worker-list")]
        public IActionResult List()
        {
            using DataContext dbcontext = new DataContext();
            var workers = dbcontext.Workers.ToList();

            var model = workers.Select(w => new WorkerlistViewModel(w.WorkerCode, w.Name, w.Surname, w.FatherName,w.IsDeleted)).ToList();
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

            if (!ModelState.IsValid)
            {
                return View(model);
            }


            dbcontext.Workers.Add(new Models.Worker
            {
                WorkerCode = WorkerPkCode.WorkerCode,
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                FatherName = model.FatherName,
                FinCode = model.FinCode,
                IsDeleted = default
            });
            dbcontext.SaveChanges();
            return RedirectToAction(nameof(List));
        }

        [HttpGet("update/{workerCode}", Name = "Worker-update-code")]
        public ActionResult Update(string workerCode)
        {
            using DataContext dbcontext = new DataContext();
            var workers = dbcontext.Workers.FirstOrDefault(w => w.WorkerCode == workerCode);


            return View(
                new UpdateViewModel
                (workers.WorkerCode, workers.Name, workers.Surname, workers.FatherName, workers.Email));
        }

        [HttpPost("update", Name = "Worker-update")]
        public ActionResult Update(UpdateViewModel model)
        {
            using DataContext dbcontext = new DataContext();
            var workers = dbcontext.Workers.FirstOrDefault(w => w.WorkerCode == model.WorkerCode);
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (workers is null)
            {
                return NotFound();
            }

            workers.Name = model.Name;
            workers.Surname = model.Surname;
            workers.FatherName = model.FatherName;
            workers.Email = model.Email;
            dbcontext.SaveChanges();
            return RedirectToAction(nameof(List));
        }


        [HttpGet("delete/{workerCode}", Name = "Worker-delete")]
        public ActionResult Delete(string workerCode)
        {
            using DataContext dbcontext = new DataContext();
            var workers = dbcontext.Workers.FirstOrDefault(w => w.WorkerCode == workerCode);

      
            if (workers is null)
            {
                return NotFound();
            }

            workers.IsDeleted = true;
            dbcontext.SaveChanges();
            return RedirectToAction(nameof(List));
        }




    }
}
