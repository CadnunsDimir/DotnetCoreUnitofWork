using DotnetCoreUnitofWork.Data;
using DotnetCoreUnitofWork.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreUnitofWork.Controllers
{
    public class TarefasController : Controller
    {
        //lista de tarefas
        

        public IActionResult Index()
        {
            using (var unitOfWork = new UnitOfWork(new SiteDbContext()))
            {
                //aqui acontece a ação
                var task = new Task{Description = "Limpar o jardim"};
                var task2 = new Task{Description = "Limpar o jardim"};
                unitOfWork.Tasks.Add(task);
                unitOfWork.Tasks.Add(task2);

                var tasks = unitOfWork.Tasks.GetAll();
                unitOfWork.Tasks.RemoveRange(tasks);
                unitOfWork.Complete();
            }
            return View();
        }
    }
}