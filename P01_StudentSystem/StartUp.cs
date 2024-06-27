using P01_StudentSystem.Data;
using P01_StudentSystem.Data.Models;
using P01_StudentSystem.Data.Models.Enums;

namespace P01_StudentSystem
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var context = new StudentSystemContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.Students.Add(new Student()
            {
                Name = "Pesho",
                PhoneNumber = "0884707103",
                RegisteredOn = DateTime.Now
            });
            context.Resources.Add(new Resource()
            {
                Course = new Course()
                {
                    Name = "C#",
                    Price = 500.0m
                },
                Name = "CSharp Fundamentals",
                ResourceType = ResourceType.Video,
                Url = "http://google.com/"
            });
            context.SaveChanges();
        }
    }
}
