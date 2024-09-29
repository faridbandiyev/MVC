using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskFrontToBack.DataAccessLayer;
using TaskFrontToBack.DataAccessLayer.Entities;

namespace TaskFrontToBack.Controllers
{
    public class TeachersController : Controller
    {
        private readonly AppDbContext _dbContext;
        public TeachersController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var teachers = _dbContext.Teachers.Include(x => x.TeacherStudents).ThenInclude(x=>x.Student).ToList();
            return View(teachers);
        }
    }
}
