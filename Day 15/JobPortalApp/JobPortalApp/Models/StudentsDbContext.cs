using Microsoft.EntityFrameworkCore;

namespace JobPortalApp.Models
{
    public class StudentsDbContext:DbContext
    {
        public StudentsDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Student> Students{ get; set; }

    }
}
