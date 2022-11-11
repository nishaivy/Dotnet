using System.ComponentModel.DataAnnotations;

namespace Student_details_MVC.Models
{
    public class Club
    {
        [Key]
        public int Id { get; set; }
        public string ClubName { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
