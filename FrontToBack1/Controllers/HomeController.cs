using Microsoft.AspNetCore.Mvc;

namespace FrontToBack1.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
