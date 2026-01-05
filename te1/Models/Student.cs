using System;
using System.Collections.Generic;
using System.Text;

namespace te1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string StudentCode { get; set; }
        public string Major { get; set; }
        public List<int> ClassRoomIds { get; set; } = new List<int>();
        public string Classes => ClassRoomIds.Count > 0
            ? string.Join(", ", ClassRoomIds)
            : "(no class)";
    }
}
