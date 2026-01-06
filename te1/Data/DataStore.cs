using System.ComponentModel;
using System.Linq;
using te1.Models;

namespace te1.Data
{
    public static class DataStore
    {
        public static BindingList<Student> Students { get; } = new();
        public static BindingList<Teacher> Teachers { get; } = new();
        public static BindingList<ClassRoom> Classes { get; } = new();

        public static int NextStudentId()
            => Students.Any() ? Students.Max(x => x.Id) + 1 : 1;

        public static int NextTeacherId()
            => Teachers.Any() ? Teachers.Max(x => x.Id) + 1 : 1;

        public static int NextClassId()
            => Classes.Any() ? Classes.Max(x => x.Id) + 1 : 1;

        public static void Seed()
        {
            if (Students.Count > 0 || Teachers.Count > 0 || Classes.Count > 0) return;

            Teachers.Add(new Teacher
            {
                Id = 1,
                Name = "Mr John",
                Email = "john@gmail.com",
                TeacherCode = "T001",
                Department = "IT",
                Salary = 1000
            });

            Teachers.Add(new Teacher
            {
                Id = 2,
                Name = "Ms Anna",
                Email = "anna@gmail.com",
                TeacherCode = "T002",
                Department = "Math",
                Salary = 1200
            });

            Classes.Add(new ClassRoom { Id = 1, Name = "10A1" });
            Classes.Add(new ClassRoom { Id = 2, Name = "10A2" });

            var maria = new Student
            {
                Id = 1,
                Name = "Maria",
                Email = "maria@gmail.com",
                StudentCode = "S001",
                Major = "IT"
            };
            maria.ClassRoomIds.Add(Classes[0].Id);
            Students.Add(maria);

            var craig = new Student
            {
                Id = 2,
                Name = "Craig",
                Email = "craig@gmail.com",
                StudentCode = "S002",
                Major = "Business"
            };
            craig.ClassRoomIds.Add(Classes[0].Id);
            craig.ClassRoomIds.Add(Classes[1].Id);
            Students.Add(craig);
        }
    }
}
