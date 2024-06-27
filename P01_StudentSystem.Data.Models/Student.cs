using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [MaxLength(100), Required] public string Name { get; set; } = string.Empty;
        [MaxLength(10)]

        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime RegisteredOn { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? Birthday  { get; set; }

        public virtual ICollection<HomeworkSubmission> HomeworkSubmissions { get; set; } = new HashSet<HomeworkSubmission>();
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
