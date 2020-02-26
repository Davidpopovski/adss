using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GradeSystem.Models;

namespace GradeSystem.Interfaces
{
    public interface IStudentService
    {
        Task<Students> NewStudent(Students newStudent);
        Task UpdateStudent(Students studentUpdate, Students student);
        Task DeleteStudent(Students student);
    }
}
