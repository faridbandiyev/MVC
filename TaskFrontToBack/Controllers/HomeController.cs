using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskFrontToBack.DataAccessLayer;
using TaskFrontToBack.Models;

namespace TaskFrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
