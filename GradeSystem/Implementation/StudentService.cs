using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GradeSystem.Interfaces;
using GradeSystem.Models;

namespace GradeSystem.Implementation
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public async Task DeleteStudent(Students student)
        {
            _unitOfWork.Students.Remove(student);

            await _unitOfWork.CommitAsync();
        }

        public async Task<Students> NewStudent(Students newStudent)
        {
            await _unitOfWork.Students
                .AddAsync(newStudent);

            return newStudent;
        }

        public async Task UpdateStudent(Students studentUpdate, Students student)
        {
            studentUpdate.FirstName = student.FirstName;
            studentUpdate.LastName = student.LastName;

            await _unitOfWork.CommitAsync();
        }
    }
}
