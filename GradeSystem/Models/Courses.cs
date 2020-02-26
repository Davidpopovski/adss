using System;
using System.Collections.Generic;

namespace GradeSystem.Models
{
    public partial class Courses
    {
        public Courses()
        {
            Grades = new HashSet<Grades>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Profesor { get; set; }
        public string SemesterYear { get; set; }
        public string Description { get; set; }
        public decimal CourseGrade { get; set; }


        public virtual ICollection<Grades> Grades { get; set; }
    }
}
