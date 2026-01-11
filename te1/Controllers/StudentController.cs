using System;
using System.ComponentModel;
using System.Linq;
using te1.Models;
using te1.Services.Interfaces;
using te1.Views.Pages.Interfaces;

namespace te1.Controllers
{
    public class StudentController
    {
        private readonly IStudentView _view;
        private readonly IStudentService _studentService;

        private BindingList<Student> _students = new();

        public StudentController(IStudentView view, IStudentService studentService)
        {
            _view = view;
            _studentService = studentService;
        }

        public void Load()
        {
            _students = _studentService.GetStudentBinding();
            _view.BindStudents(_students);
        }

        public void Add()
        {
            try
            {
                if (!_view.TryGetNewStudent(out var student)) return;
                var created = _studentService.AddStudent(student);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }
        public void Edit()
        {
            try
            {
                var current = _view.GetSelectedStudent();
                if (current is null) return;
                if (!_view.TryEditStudent(current, out var updated)) return;
                _studentService.UpdateStudent(current.Id, updated);
                _view.RefreshCurrent();
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }
        public void Delete()
        {
            try
            {
                var current = _view.GetSelectedStudent();
                if (current is null)
                {
                    _view.ShowError("Chọn 1 student để Delete");
                    return;
                }

                if (!_view.ConfirmDelete(current)) return;

                _studentService.DeleteStudent(current.Id);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }
        public System.Collections.Generic.List<Student> GetStudentsInClass(int classId)
        {
            return _studentService.GetStudentsInClass(classId);
        }

        public void RefreshStudents()
        {
            _students = _studentService.GetStudentBinding();
            _view.BindStudents(_students);
        }
    }
}