using System;
using System.Collections.Generic;

namespace GradeSystem.Models
{
    public partial class Grades
    {
        public int GradeId { get; set; }
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }
        public int? Grade { get; set; }

        public virtual Courses Course { get; set; }
        public virtual Students Student { get; set; }
    }
}
