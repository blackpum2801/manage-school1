using System.Collections.Generic;
using te1.Models;

namespace te1
{
    public class AppData
    {
        public List<Student> Students { get; set; } = new();
        public List<Teacher> Teachers { get; set; } = new();
        public List<ClassRoom> Classes { get; set; } = new();

        public int NextStudentId { get; set; } = 1;
        public int NextTeacherId { get; set; } = 1;
        public int NextClassId { get; set; } = 1;
    }
}
