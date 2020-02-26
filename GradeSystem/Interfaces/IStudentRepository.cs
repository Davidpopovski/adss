using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GradeSystem.Models;

namespace GradeSystem.Interfaces
{
    public interface IStudentRepository : IRepository<Students>
    {
        Task<IEnumerable<Students>> GetStudents();
        Task<Students> GetStudentsById(int id);
    }
}
