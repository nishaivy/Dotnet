using College_MVC.Models;
using System.ComponentModel.DataAnnotations;

namespace Student_details_MVC.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string CourseName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
