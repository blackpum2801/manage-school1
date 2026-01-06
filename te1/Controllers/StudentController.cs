using System;
using System.ComponentModel;
using System.Linq;
using te1.Models;
using te1.Services;
using te1.Views.Pages;

namespace te1.Controllers
{
    public class StudentController
    {
        private readonly IStudentView _view;
        private readonly SchoolService _service;

        private BindingList<Student> _students = new();

        public StudentController(IStudentView view, SchoolService service)
        {
            _view = view;
            _service = service;
        }

        public void Load()
        {
            _students = new BindingList<Student>(_service.GetAllStudents().ToList());
            _view.BindStudents(_students);
        }

        public void Add()
        {
            try
            {
                if (!_view.TryGetNewStudent(out var student)) return;

                var created = _service.AddStudent(student);

                _students.Add(created);
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

                _service.UpdateStudent(current.Id, updated);

                // update object đang bind
                current.Name = updated.Name;
                current.Email = updated.Email;
                current.StudentCode = updated.StudentCode;
                current.Major = updated.Major;

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

                _service.DeleteStudent(current.Id);
                _students.Remove(current);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }
    }
}
