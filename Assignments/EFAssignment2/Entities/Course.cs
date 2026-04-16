using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFAssignment2.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public int Credits { get; set; }

        public List<Enrollment> Enrollments { get; set; }
    }
}
