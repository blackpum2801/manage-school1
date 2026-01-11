using System.ComponentModel;
using te1.Models;

namespace te1.Services.Interfaces
{
    public interface ISchoolService : IStudentService, ITeacherService, IClassService
    {
       
    }
}