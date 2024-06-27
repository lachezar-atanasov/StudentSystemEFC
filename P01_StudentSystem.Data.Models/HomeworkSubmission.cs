using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models.Enums;

namespace P01_StudentSystem.Data.Models
{
    public class HomeworkSubmission
    {
        [Key]
        public int HomeworkId { get; set; }
        [Unicode(false)]
        public string Content { get; set; } = String.Empty;
        public ContentType ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; } = new Student();

        public int CourseId { get; set; }
        public virtual Course Course { get; set; } = new Course();
    }
}
