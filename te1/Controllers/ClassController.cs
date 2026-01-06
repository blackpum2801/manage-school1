using System;
using System.Linq;
using te1.Models;
using te1.Services;
using te1.Views.Pages;

namespace te1.Controllers
{
    public class ClassController
    {
        private readonly IClassView _view;
        private readonly SchoolService _service;

        public ClassController(IClassView view, SchoolService service)
        {
            _view = view;
            _service = service;
        }

        public void Load()
        {
            _view.BindClasses(_service.GetClassBinding());
            _view.BindTeachers(_service.GetTeacherBinding());
            _view.BindStudents(_service.GetStudentBinding());

            RefreshView();
        }

        public void RefreshView()
        {
            var cls = _view.GetSelectedClass();
            if (cls is null)
            {
                _view.ShowStudentsInClass(new());
                _view.ShowHomeroom("GVCN: (none)");
                return;
            }

            var students = _service.GetStudentsInClass(cls.Id).ToList();
            _view.ShowStudentsInClass(students);

            var homeroomName = _service.GetHomeroomTeacherName(cls);
            _view.ShowHomeroom($"GVCN: {homeroomName}");
        }

        public void CreateClass()
        {
            try
            {
                var name = _view.GetNewClassName();
                _service.CreateClass(name);
                _view.ClearNewClassName();

                // DataSource đang bind BindingList => tự update
                RefreshView();
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        public void DeleteClass()
        {
            try
            {
                var cls = _view.GetSelectedClass();
                if (cls is null) return;

                var ok = _view.Confirm(
                    $"Xóa lớp '{cls.Name}'?\n(Học sinh trong lớp sẽ bị xóa khỏi lớp này)",
                    "Confirm");

                if (!ok) return;

                _service.DeleteClass(cls.Id);
                RefreshView();
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        public void AssignHomeroomTeacher()
        {
            try
            {
                var cls = _view.GetSelectedClass();
                var teacher = _view.GetSelectedTeacher();
                if (cls is null || teacher is null) return;

                _service.AssignHomeroomTeacher(cls.Id, teacher.Id);
                RefreshView();
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        public void AddStudentToClass()
        {
            try
            {
                var cls = _view.GetSelectedClass();
                var student = _view.GetSelectedStudent();
                if (cls is null || student is null) return;

                _service.AddStudentToClass(cls.Id, student.Id);
                RefreshView();
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }
    }
}
