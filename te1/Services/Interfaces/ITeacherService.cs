using System.Collections.Generic;
using System.ComponentModel;
using te1.Models;

namespace te1.Services.Interfaces
{
    public interface ITeacherService
    {
        // Binding
        BindingList<Teacher> GetTeacherBinding();

        // Basic CRUD
        List<Teacher> GetAllTeachers();
        Teacher AddTeacher(Teacher teacher);
        void UpdateTeacher(int id, Teacher updated);
        void DeleteTeacher(int id);

        // Class-related
        string GetHomeroomTeacherName(ClassRoom cls);
    }
}