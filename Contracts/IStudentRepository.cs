using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents(bool trackChanges);
        Student GetStudent(Guid studentId, bool trackChanges);
        void CreateStudent(Student student);
        void DeleteStudent(Student student);
    }
}