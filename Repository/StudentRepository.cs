using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class StudentRepository : RepositoryBase<Student>,IStudentRepository
    {
        
        public StudentRepository(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }

        public void CreateStudent(Student student)
        {
            Create(student);
        }

        public void DeleteStudent(Student student)
        {
            Delete(student);
        }

        public IEnumerable<Student> GetAllStudents(bool trackChanges)
        {
            return FindAll(trackChanges).OrderBy(s => s.LastName).ThenBy(s => s.FirstName).ToList();
        }

        public Student GetStudent(Guid studentId, bool trackChanges)
        {
            return FindByCondition(s => s.Id.Equals(studentId), trackChanges).SingleOrDefault();
        }
    }
}