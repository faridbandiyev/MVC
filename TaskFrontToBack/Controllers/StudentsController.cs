using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskFrontToBack.DataAccessLayer;

namespace TaskFrontToBack.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDbContext _dbContext;
        public StudentsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var students = _dbContext.Students.Include(x=> x.TeacherStudents).ThenInclude(x=>x.Teacher).ToList();
            return View(students);
        }
    }
}
