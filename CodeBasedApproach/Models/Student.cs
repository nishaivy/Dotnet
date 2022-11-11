using System.ComponentModel.DataAnnotations;

namespace CodeBasedApproach.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
       
        public string Name { get; set; }
        public DateTime Student_DOB { get; set; }
        /*public int Course_Id { get; set; }
        public int Club_Id { get; set; }
*/


       

    }
}
