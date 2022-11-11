using College_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Student_details_MVC;
using Student_details_MVC.Models;
using System.Collections.Generic;

namespace College_MVC
{
    public class MydbContext : DbContext
    {
      public MydbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<teacher> Teachers { get; set; }
  }
}





