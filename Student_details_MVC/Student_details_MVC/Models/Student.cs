using System.ComponentModel.DataAnnotations;

namespace Student_details_MVC.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
       
        public string StudentName { get; set; }
         
       
        public DateTime StudentDob { get; set; }
    }
}
