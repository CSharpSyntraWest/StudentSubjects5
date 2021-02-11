using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSubjects.Controllers
{
    [Route("api/studentsubjects")]
    [ApiController]
    public class StudentSubjectsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public StudentSubjectsController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetStudentSubjects()
        {
            var studentSubjects = _repository.StudentSubject.GetAllStudentSubjects(false);
            return Ok(studentSubjects);
        }
        [HttpGet("{subjectId}")]
        public IActionResult StudentsBySubjectId(Guid subjectId)
        {
            var subjectStudents = _repository.StudentSubject.GetStudentsBySubjectId(subjectId, false);
            return Ok(subjectStudents);
        }

    }
}
