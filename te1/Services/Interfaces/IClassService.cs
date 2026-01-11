using System.Collections.Generic;
using System.ComponentModel;
using te1.Models;

namespace te1.Services.Interfaces
{
    public interface IClassService
    {
        // Binding
        BindingList<ClassRoom> GetClassBinding();

        // Basic CRUD
        ClassRoom CreateClass(string name);
        void DeleteClass(int classId);

        // Student Management
        List<Student> GetStudentsInClass(int classId);
        void AddStudentToClass(int classId, int studentId);

        // Teacher Management
        void AssignHomeroomTeacher(int classId, int teacherId);
        string GetHomeroomTeacherName(ClassRoom cls);
    }
}