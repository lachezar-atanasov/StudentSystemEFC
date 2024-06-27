using System.ComponentModel.DataAnnotations;

namespace P01_StudentSystem.Data.Models
{
    public class Course
    {
        public int CourseId {get;set;}
        [MaxLength(80)]
        public string Name { get;set;} = string.Empty;
        public string? Description { get;set;}
        public DateTime StartDate { get;set;}
        public DateTime EndDate { get;set;}
        public decimal Price { get;set;}

        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
