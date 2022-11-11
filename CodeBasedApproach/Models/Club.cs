using System.ComponentModel.DataAnnotations;
namespace CodeBasedApproach.Models
{
    public class Club
    {
        [Key]
        public int Id { get; set; }
        public string Club_Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
