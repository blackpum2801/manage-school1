using System.Collections.Generic;
using System.ComponentModel;
using te1.Models;

namespace te1.Views.Pages.Interfaces
{
    public interface IClassView
    {
        void BindClasses(BindingList<ClassRoom> classes);
        void BindTeachers(BindingList<Teacher> teachers);
        void BindStudents(BindingList<Student> students);

        ClassRoom? GetSelectedClass();
        Teacher? GetSelectedTeacher();
        Student? GetSelectedStudent();

        string GetNewClassName();
        void ClearNewClassName();

        void ShowHomeroom(string text);
        void ShowStudentsInClass(List<Student> students);
        bool Confirm(string message, string title);

        void ShowError(string message);
    }
}
