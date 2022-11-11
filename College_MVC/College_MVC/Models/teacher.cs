using System.ComponentModel.DataAnnotations;

namespace College_MVC.Models
{
    public class teacher
    {
        [Key]
        public int Id { get; set; }
        public string teacherName { get; set; }
        public ICollection<Student> Students { get; set; }
    }

}
