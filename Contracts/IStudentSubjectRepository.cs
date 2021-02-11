using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IStudentSubjectRepository
    {
        IEnumerable<StudentSubject> GetAllStudentSubjects(bool trackChanges);
        void CreateStudentSubject(StudentSubject studentSubject);
        void DeleteStudentSubject(StudentSubject studentSubject);
        IEnumerable<StudentSubject> GetSubjectsByStudentId(Guid studentId, bool trackChanges);
        IEnumerable<StudentSubject> GetStudentsBySubjectId(Guid subjectId, bool trackChanges);
        StudentSubject GetStudentSubject(StudentSubject studentSubject, bool trackChanges);
    }
}