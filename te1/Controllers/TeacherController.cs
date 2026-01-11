using System;
using System.ComponentModel;
using System.Linq;
using te1.Models;
using te1.Services.Interfaces;
using te1.Views.Pages.Interfaces;

namespace te1.Controllers
{
    public class TeacherController
    {
        private readonly ITeacherView _view;
        private readonly ITeacherService _teacherService;

        private BindingList<Teacher> _teachers = new();

        public TeacherController(ITeacherView view, ITeacherService teacherService)
        {
            _view = view;
            _teacherService = teacherService;
        }

        public void Load()
        {
            _teachers = _teacherService.GetTeacherBinding();
            _view.BindTeachers(_teachers);
        }

        public void Add()
        {
            try
            {
                if (!_view.TryGetNewTeacher(out var teacher)) return;

                var created = _teacherService.AddTeacher(teacher);
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

                _teacherService.UpdateTeacher(current.Id, updated);
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

                _teacherService.DeleteTeacher(current.Id);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }
        public void RefreshTeachers()
        {
            _teachers = _teacherService.GetTeacherBinding();
            _view.BindTeachers(_teachers);
        }
    }
}