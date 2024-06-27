using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using P01_StudentSystem.Data.Models.Enums;

namespace P01_StudentSystem.Data.Models
{
    public class Resource
    {
        public int ResourceId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [Unicode(false)] public string Url { get; set; } = string.Empty;
        public ResourceType ResourceType { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; } = new Course();
    }
}
