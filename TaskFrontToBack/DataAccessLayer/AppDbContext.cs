using Microsoft.EntityFrameworkCore;
using TaskFrontToBack.DataAccessLayer.Entities;

namespace TaskFrontToBack.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
