using System.ComponentModel.DataAnnotations;

namespace CodeBasedApproach.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; } 

        public string Course_Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
