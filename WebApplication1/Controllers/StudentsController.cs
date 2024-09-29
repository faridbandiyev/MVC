using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
	public class StudentsController : Controller
	{
		public IActionResult Index()
		{
			var students = new List<Student>
			{
				new("Ferid", 1),
				new("Musa", 2),
				new("Asman", 3)
			};

			var teachers = new List<Teacher>
			{
				new("Imran", 1),
				new("Aqil", 2),
				new("Raul", 3)
			};

			var viewModel = new StudentViewModel()
			{
				Students = students,
				Teachers = teachers
			};

			return View(viewModel);
		}

		public IActionResult Details(int? id)
		{

			if (id == null) return NotFound();

			var students = new List<Student>
			{
				new("Ferid", 1),
				new("Musa", 2),
				new("Asman", 3)
			};

			var student = students.Find(student => student.Id == id);

			if (student == null) return NotFound();

			return View(student); ;
		}

		public IActionResult Test()
		{
			return View();
		}
	}
}
