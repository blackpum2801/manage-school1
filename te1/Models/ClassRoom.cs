using System.Collections.Generic;

namespace te1.Models
{
    public class ClassRoom
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int? HomeroomTeacherId { get; set; }   
        public override string ToString() => Name;   
    }
}
