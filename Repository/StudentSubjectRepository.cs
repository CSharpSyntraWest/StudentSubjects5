using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class StudentSubjectRepository : RepositoryBase<StudentSubject> ,IStudentSubjectRepository
    {
        
        public StudentSubjectRepository(RepositoryContext repositoryContext):base(repositoryContext)
        {
          
        }

        public void CreateStudentSubject(StudentSubject studentSubject)
        {
            Create(studentSubject);
        }

        public void DeleteStudentSubject(StudentSubject studentSubject)
        {
            Delete(studentSubject);
        }

        public IEnumerable<StudentSubject> GetAllStudentSubjects(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public IEnumerable<StudentSubject> GetStudentsBySubjectId(Guid subjectId, bool trackChanges)
        {
            return FindByCondition(s => s.SubjectId.Equals(subjectId), trackChanges).ToList();
        }

        public StudentSubject GetStudentSubject(StudentSubject studentSubject, bool trackChanges)
        {
            return FindByCondition(s => s.SubjectId.Equals(studentSubject.SubjectId) 
            && s.StudentId.Equals(studentSubject.StudentId), trackChanges).SingleOrDefault();
        }

        public IEnumerable<StudentSubject> GetSubjectsByStudentId(Guid studentId, bool trackChanges)
        {
            return FindByCondition(s => s.StudentId.Equals(studentId), trackChanges);
        }
    }
}