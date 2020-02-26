using System;
using System.Collections.Generic;

namespace GradeSystem.Models
{
    public partial class Students
    {
        public Students()
        {
            Grades = new HashSet<Grades>();
        }

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentIndex { get; set; }
        public decimal GPA { get; set; }

        public virtual ICollection<Grades> Grades { get; set; }
    }
}
