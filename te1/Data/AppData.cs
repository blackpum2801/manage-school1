using System.Collections.Generic;
using te1.Models;

namespace te1.Data
{
    public class AppData
    {
        public List<Student> Students { get; set; } = new();
        public List<Teacher> Teachers { get; set; } = new();
        public List<ClassRoom> Classes { get; set; } = new();
    }
}
