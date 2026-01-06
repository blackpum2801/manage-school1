using System;
using System.ComponentModel;
using System.Linq;
using te1.Models;
using te1.Services;
using te1.Views.Pages;

namespace te1.Controllers
{
    public class TeacherController
    {
        private readonly ITeacherView _view;
        private readonly SchoolService _service;

        private BindingList<Teacher> _teachers = new();

        public TeacherController(ITeacherView view, SchoolService service)
        {
            _view = view;
            _service = service;
        }

        public void Load()
        {
            _teachers = new BindingList<Teacher>(_service.GetAllTeachers().ToList());
            _view.BindTeachers(_teachers);
        }

        public void Add()
        {
            try
            {
                if (!_view.TryGetNewTeacher(out var teacher)) return;

                var created = _service.AddTeacher(teacher); 
                _teachers.Add(created);
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
                var current = _view.GetSelectedTeacher();
                if (current is null) return;

                if (!_view.TryEditTeacher(current, out var updated)) return;

                _service.UpdateTeacher(current.Id, updated);

                current.Name = updated.Name;
                current.Email = updated.Email;
                current.TeacherCode = updated.TeacherCode;
                current.Department = updated.Department;
                current.Salary = updated.Salary;

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
                var current = _view.GetSelectedTeacher();
                if (current is null)
                {
                    _view.ShowError("Chọn 1 teacher để Delete");
                    return;
                }

                if (!_view.ConfirmDelete(current)) return;

                _service.DeleteTeacher(current.Id);
                _teachers.Remove(current);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }
    }
}
