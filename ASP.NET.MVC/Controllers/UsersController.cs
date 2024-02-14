using ASP.NET.MVC.Models.Db.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ASP.NET.MVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly IBlogRepository _repo;

        public UsersController(IBlogRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var authors = await _repo.GetUsers();
            return View(authors);
        }
    }
}
