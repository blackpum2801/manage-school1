using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using te1.Data;
using te1.Models;
using te1.Services.Interfaces;

namespace te1.Services
{
    public class SchoolService : ISchoolService
    {
        // IStudentService implementation
        public BindingList<Student> GetStudentBinding() => DataStore.Students;

        public List<Student> GetAllStudents()
            => DataStore.Students.ToList();

        public Student AddStudent(Student student)
        {
            ValidateStudent(student);

            student.Id = DataStore.NextStudentId();
            DataStore.Students.Add(student);

            return student;
        }

        public void UpdateStudent(int id, Student updated)
        {
            ValidateStudent(updated, id);

            var current = DataStore.Students.FirstOrDefault(s => s.Id == id)
                          ?? throw new Exception("Student not found");

            current.Name = updated.Name;
            current.Email = updated.Email;
            current.StudentCode = updated.StudentCode;
            current.Major = updated.Major;
        }

        public void DeleteStudent(int id)
        {
            var student = DataStore.Students.FirstOrDefault(s => s.Id == id);
            if (student != null)
                DataStore.Students.Remove(student);
        }

        private void ValidateStudent(Student s, int? ignoreId = null)
        {
            if (string.IsNullOrWhiteSpace(s.Name))
                throw new Exception("Name không được để trống");

            if (string.IsNullOrWhiteSpace(s.Email))
                throw new Exception("Email không được để trống");

            if (string.IsNullOrWhiteSpace(s.StudentCode))
                throw new Exception("StudentCode không được để trống");

            var duplicated = DataStore.Students.Any(x =>
                x.StudentCode == s.StudentCode &&
                (!ignoreId.HasValue || x.Id != ignoreId.Value));

            if (duplicated)
                throw new Exception("StudentCode đã tồn tại");
        }

        public List<Student> GetStudentsInClass(int classId)
        {
            return DataStore.Students
                .Where(s => s.ClassRoomIds.Contains(classId))
                .ToList();
        }

        // ITeacherService implementation
        public BindingList<Teacher> GetTeacherBinding() => DataStore.Teachers;

        public List<Teacher> GetAllTeachers()
            => DataStore.Teachers.ToList();

        public Teacher AddTeacher(Teacher teacher)
        {
            ValidateTeacher(teacher);

            teacher.Id = DataStore.NextTeacherId();
            DataStore.Teachers.Add(teacher);

            return teacher;
        }

        public void UpdateTeacher(int id, Teacher updated)
        {
            ValidateTeacher(updated, id);

            var current = DataStore.Teachers.FirstOrDefault(t => t.Id == id)
                          ?? throw new Exception("Teacher not found");

            current.Name = updated.Name;
            current.Email = updated.Email;
            current.TeacherCode = updated.TeacherCode;
            current.Department = updated.Department;
            current.Salary = updated.Salary;
        }

        public void DeleteTeacher(int id)
        {
            var t = DataStore.Teachers.FirstOrDefault(x => x.Id == id);
            if (t != null)
                DataStore.Teachers.Remove(t);
        }

        private void ValidateTeacher(Teacher t, int? ignoreId = null)
        {
            if (string.IsNullOrWhiteSpace(t.Name))
                throw new Exception("Teacher name không được để trống");

            if (string.IsNullOrWhiteSpace(t.Email))
                throw new Exception("Teacher email không được để trống");

            if (string.IsNullOrWhiteSpace(t.TeacherCode))
                throw new Exception("TeacherCode không được để trống");

            var duplicated = DataStore.Teachers.Any(x =>
                x.TeacherCode == t.TeacherCode &&
                (!ignoreId.HasValue || x.Id != ignoreId.Value));

            if (duplicated)
                throw new Exception("TeacherCode đã tồn tại");
        }

        public string GetHomeroomTeacherName(ClassRoom cls)
        {
            if (!cls.HomeroomTeacherId.HasValue) return "(none)";
            var t = DataStore.Teachers.FirstOrDefault(x => x.Id == cls.HomeroomTeacherId.Value);
            return t?.Name ?? "(none)";
        }

        // IClassService implementation
        public BindingList<ClassRoom> GetClassBinding() => DataStore.Classes;

        public ClassRoom CreateClass(string name)
        {
            name = (name ?? "").Trim();

            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Tên lớp không được trống");

            if (DataStore.Classes.Any(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                throw new Exception("Tên lớp đã tồn tại");

            var cls = new ClassRoom
            {
                Id = DataStore.NextClassId(),
                Name = name
            };

            DataStore.Classes.Add(cls);
            return cls;
        }

        public void DeleteClass(int classId)
        {
            var cls = DataStore.Classes.FirstOrDefault(c => c.Id == classId);
            if (cls is null) return;

            // remove students from class
            foreach (var s in DataStore.Students)
            {
                if (s.ClassRoomIds.Contains(classId))
                    s.ClassRoomIds.Remove(classId);
            }

            // clear homeroom teacher
            if (cls.HomeroomTeacherId.HasValue)
            {
                var teacher = DataStore.Teachers.FirstOrDefault(t => t.Id == cls.HomeroomTeacherId.Value);
                if (teacher != null)
                    teacher.HomeroomClassId = null;
            }

            DataStore.Classes.Remove(cls);
        }

        public void AssignHomeroomTeacher(int classId, int teacherId)
        {
            var cls = DataStore.Classes.FirstOrDefault(c => c.Id == classId)
                      ?? throw new Exception("Class not found");

            var teacher = DataStore.Teachers.FirstOrDefault(t => t.Id == teacherId)
                          ?? throw new Exception("Teacher not found");

            if (teacher.HomeroomClassId.HasValue && teacher.HomeroomClassId.Value != classId)
                throw new Exception($"Teacher '{teacher.Name}' đang chủ nhiệm lớp khác!");

            if (cls.HomeroomTeacherId.HasValue && cls.HomeroomTeacherId.Value != teacherId)
            {
                var old = DataStore.Teachers.FirstOrDefault(t => t.Id == cls.HomeroomTeacherId.Value);
                if (old != null)
                    old.HomeroomClassId = null;
            }

            cls.HomeroomTeacherId = teacherId;
            teacher.HomeroomClassId = classId;
        }

        public void AddStudentToClass(int classId, int studentId)
        {
            var cls = DataStore.Classes.FirstOrDefault(c => c.Id == classId)
                      ?? throw new Exception("Class not found");

            var student = DataStore.Students.FirstOrDefault(s => s.Id == studentId)
                          ?? throw new Exception("Student not found");

            if (student.ClassRoomIds.Contains(classId))
                throw new Exception($"Học sinh '{student.Name}' đã có trong lớp '{cls.Name}'");

            student.ClassRoomIds.Add(classId);
        }
    }
}