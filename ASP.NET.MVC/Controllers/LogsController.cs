using ASP.NET.MVC.Models.Db.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ASP.NET.MVC.Controllers
{
    public class LogsController : Controller
    {
        private ILoggingRepository _loggingRepository;
        public LogsController(ILoggingRepository loggingRepository)
        {
            _loggingRepository = loggingRepository;
        }

        public async  Task <IActionResult> Index()
        {
            var requests = await _loggingRepository.GetRequests();
            return View(requests);
        }
    }
}
