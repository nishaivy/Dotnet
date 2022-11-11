using Microsoft.EntityFrameworkCore;
using CodeBasedApproach.Models;

namespace CodeBasedApproach
{
    public class MyAppDBContext:DbContext
    {
        public MyAppDBContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Club> Clubs { get; set; }


    }
}
