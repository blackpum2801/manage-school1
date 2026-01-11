using System.Collections.Generic;
using System.ComponentModel;
using te1.Models;

namespace te1.Services.Interfaces
{
    public interface IStudentService
    {
        // Binding
        BindingList<Student> GetStudentBinding();

        // Basic CRUD
        List<Student> GetAllStudents();
        Student AddStudent(Student student);
        void UpdateStudent(int id, Student updated);
        void DeleteStudent(int id);

        // Class-related
        List<Student> GetStudentsInClass(int classId);
    }
}