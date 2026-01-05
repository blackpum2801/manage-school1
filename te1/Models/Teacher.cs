using System;
using System.Collections.Generic;
using System.Text;

namespace te1.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TeacherCode { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public int? HomeroomClassId { get; set; }
    }
}
