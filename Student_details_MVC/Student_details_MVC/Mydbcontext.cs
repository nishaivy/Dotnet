using Microsoft.EntityFrameworkCore;
using Student_details_MVC.Models;

namespace Student_details_MVC
{
    public class Mydbcontext:DbContext
    {
        public Mydbcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Club> Clubs { get; set; }
    }
}
