using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFAssignment2.Entities
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }
        public String? Name { get; set; }
        public string? Email { get; set; }

        public List<Enrollment>? Enrollments { get; set; }
    }
}
