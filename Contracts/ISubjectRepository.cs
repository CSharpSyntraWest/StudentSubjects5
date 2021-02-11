using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface ISubjectRepository
    {
        IEnumerable<Subject> GetAllSubjects(bool trackChanges);
        Subject GetSubject(Guid subjectId, bool trackChanges);
        void CreateSubject(Subject subject);
        void DeleteSubject(Subject subject);
    }
}