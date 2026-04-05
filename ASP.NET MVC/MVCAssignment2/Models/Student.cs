using System.ComponentModel.DataAnnotations;

namespace MVCAssignment2.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Pls Enter Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Pls Enter Id")]
        [StringLength(50)]
        public string? Name { get; set; }

        [Range(18,60,ErrorMessage = "Pls Enter your Vaild age in b/w 5 - 50")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Pls Enter Id")]
        [EmailAddress]
        public string? Email { get; set; }
        public List<Course>? Courses { get; set; } = new List<Course>();
    }
}
