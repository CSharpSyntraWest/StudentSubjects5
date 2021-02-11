using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IStudentRepository _studentRepository;
        private ISubjectRepository _subjectRepository;
        private IStudentSubjectRepository _studentSubjectRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public IStudentRepository Student 
        {
            get {
                if (_studentRepository == null)
                    _studentRepository = new StudentRepository(_repositoryContext);
                return _studentRepository;
            }
        }

        public ISubjectRepository Subject 
        {
            get {
                if (_subjectRepository == null)
                    _subjectRepository = new SubjectRepository(_repositoryContext);
                return _subjectRepository;
            }
        
        }

        public IStudentSubjectRepository StudentSubject
        {
            get {
                if (_studentSubjectRepository == null)
                    _studentSubjectRepository = new StudentSubjectRepository(_repositoryContext);
                return _studentSubjectRepository;

            }
            
        }
        public void Save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}
