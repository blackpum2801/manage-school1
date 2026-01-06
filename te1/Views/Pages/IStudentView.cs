using System.ComponentModel;
using te1.Models;

namespace te1.Views.Pages
{
    public interface IStudentView
    {
        void BindStudents(BindingList<Student> students);

        Student? GetSelectedStudent();
        void RefreshCurrent();

        bool ConfirmDelete(Student student);
        bool TryGetNewStudent(out Student student);
        bool TryEditStudent(Student current, out Student updated);

        void ShowError(string message);
    }
}
