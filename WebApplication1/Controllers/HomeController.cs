using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            return Content($"Id: {id}");
        }

        public ViewResult About()
        {
            var viewResult = new ViewResult();
            viewResult.ViewName = "About";
            return viewResult;
        }

        public IActionResult Contact()
        {
            return Json(new { name = "Ferid", age = 23 });
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
