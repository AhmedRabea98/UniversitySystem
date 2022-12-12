using Microsoft.EntityFrameworkCore;

namespace UniversitySystem.Models
{
    public class DBContext:DbContext
    {
        public DBContext()
        {

        }
        public DBContext(DbContextOptions<DBContext>options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }


    }
}
