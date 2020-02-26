using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GradeSystem.Models;

namespace GradeSystem.Interfaces
{
    public interface ICourseService
    {
        Task<Courses> NewCourse(Courses newCourse);
        Task UpdateCourse(Courses courseUpdate, Courses course);
        Task DeleteCourse(Courses course);
    }
}
