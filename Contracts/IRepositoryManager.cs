using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IStudentRepository Student { get; }
        ISubjectRepository Subject { get; }
        IStudentSubjectRepository StudentSubject { get; }
        void Save();
    }
}
