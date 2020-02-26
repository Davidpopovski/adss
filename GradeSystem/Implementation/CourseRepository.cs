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
    public class CourseRepository : Repository<Courses>, ICourseRepository
    {
        private readonly GradeSystemContext _context;
        public CourseRepository(GradeSystemContext context)
          : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Courses>> GetCourses()
        {
            var courses = await _context.Courses.ToListAsync();

            return courses;
        }

        public async Task<Courses> GetCourseById(int id)
        {
            var course = await _context.Courses.SingleOrDefaultAsync(a => a.CourseId == id);

            return course;
        }
    }
}
