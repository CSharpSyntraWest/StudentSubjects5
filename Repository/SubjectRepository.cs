using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class SubjectRepository : RepositoryBase<Subject>, ISubjectRepository
    {

        public SubjectRepository(RepositoryContext repositoryContext):base(repositoryContext)
        {
            
        }

        public void CreateSubject(Subject subject)
        {
            Create(subject);
        }

        public void DeleteSubject(Subject subject)
        {
            Delete(subject);
        }

        public IEnumerable<Subject> GetAllSubjects(bool trackChanges)
        {
            return FindAll(trackChanges).OrderBy(s => s.Name).ToList();
        }

        public Subject GetSubject(Guid subjectId, bool trackChanges)
        {
            return FindByCondition(s => s.Id.Equals(subjectId), trackChanges).SingleOrDefault();
        }
    }
}