using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GradeSystem.Data;
using GradeSystem.Interfaces;
using GradeSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace GradeSystem.Implementation
{
    public class StudentRepository : Repository<Students>, IStudentRepository
    {
        private readonly GradeSystemContext _context;
        public StudentRepository(GradeSystemContext context)
          : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Students>> GetStudents()
        {
            var students = await _context.Students.ToListAsync();

            return students;
        }

        public async Task<Students> GetStudentsById(int id)
        {
            var student = await _context.Students.SingleOrDefaultAsync(a => a.StudentId == id);

            return student;
        }
    }
}
