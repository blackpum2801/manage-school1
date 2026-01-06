using System.ComponentModel;
using te1.Models;

namespace te1.Views.Pages
{
    public interface ITeacherView
    {
        void BindTeachers(BindingList<Teacher> teachers);

        Teacher? GetSelectedTeacher();
        void RefreshCurrent();

        bool ConfirmDelete(Teacher teacher);
        bool TryGetNewTeacher(out Teacher teacher);
        bool TryEditTeacher(Teacher current, out Teacher updated);

        void ShowError(string message);
    }
}
