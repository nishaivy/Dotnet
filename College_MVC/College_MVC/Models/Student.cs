using System.ComponentModel.DataAnnotations;

namespace College_MVC.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public int standard { get; set; }
        
    }
}
