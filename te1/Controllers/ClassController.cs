using System;
using System.Linq;
using te1.Models;
using te1.Services.Interfaces;
using te1.Views.Pages.Interfaces;

namespace te1.Controllers
{
    public class ClassController
    {
        private readonly IClassView _view;
        private readonly IClassService _classService;
        private readonly ITeacherService _teacherService;
        private readonly IStudentService _studentService;
        public ClassController(
            IClassView view,
            IClassService classService,
            ITeacherService teacherService,
            IStudentService studentService)
        {
            _view = view;
            _classService = classService;
            _teacherService = teacherService;
            _studentService = studentService;
        }
        public void Load()
        {
            _view.BindClasses(_classService.GetClassBinding());
            _view.BindTeachers(_teacherService.GetTeacherBinding());
            _view.BindStudents(_studentService.GetStudentBinding());

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
            var students = _classService.GetStudentsInClass(cls.Id).ToList();
            _view.ShowStudentsInClass(students);

            var homeroomName = _classService.GetHomeroomTeacherName(cls);
            _view.ShowHomeroom($"GVCN: {homeroomName}");
        }
        public void CreateClass()
        {
            try
            {
                var name = _view.GetNewClassName();
                _classService.CreateClass(name);
                _view.ClearNewClassName();
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

                _classService.DeleteClass(cls.Id);
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

                _classService.AssignHomeroomTeacher(cls.Id, teacher.Id);
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

                _classService.AddStudentToClass(cls.Id, student.Id);
                RefreshView();
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        public System.Collections.Generic.List<ClassRoom> GetAllClasses()
        {
            return _classService.GetClassBinding().ToList();
        }

        public ClassRoom GetClassById(int id)
        {
            return _classService.GetClassBinding()
                .FirstOrDefault(c => c.Id == id);
        }
    }
}