using System.ComponentModel;
using te1.Models;

namespace te1
{
    public static class DataStore
    {
        public static BindingList<Student> Students { get; set; } = new();
        public static BindingList<Teacher> Teachers { get; set; } = new();
        public static BindingList<ClassRoom> Classes { get; set; } = new();

        public static int NextStudentId = 1;
        public static int NextTeacherId = 1;
        public static int NextClassId = 1;

        public static void Seed()
        {
            if (Students.Count > 0 || Teachers.Count > 0 || Classes.Count > 0) return;

            Teachers.Add(new Teacher
            {
                Id = NextTeacherId++,
                Name = "Mr John",
                Email = "john@gmail.com",
                TeacherCode = "T001",
                Department = "IT",
                Salary = 1000
            });

            Teachers.Add(new Teacher
            {
                Id = NextTeacherId++,
                Name = "Ms Anna",
                Email = "anna@gmail.com",
                TeacherCode = "T002",
                Department = "Math",
                Salary = 1200
            });

            Classes.Add(new ClassRoom { Id = NextClassId++, Name = "10A1" });
            Classes.Add(new ClassRoom { Id = NextClassId++, Name = "10A2" });

            var maria = new Student
            {
                Id = NextStudentId++,
                Name = "Maria",
                Email = "maria@gmail.com",
                StudentCode = "S001",
                Major = "IT"
            };
            maria.ClassRoomIds.Add(Classes[0].Id);
            Students.Add(maria);

            var craig = new Student
            {
                Id = NextStudentId++,
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