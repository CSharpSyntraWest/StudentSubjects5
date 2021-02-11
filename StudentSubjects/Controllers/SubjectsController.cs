using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSubjects.Controllers
{
    [Route("api/subjects")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public SubjectsController(IRepositoryManager repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IActionResult GetSubjects()
        {
            var subjects = _repository.Subject.GetAllSubjects(false);
            return Ok(subjects);
        }

        [HttpGet("{id}")]
        public IActionResult GetSubject(Guid id)
        {
            var subject = _repository.Subject.GetSubject(id,false);
            if (subject == null)
            {
                return NotFound();
            }
            return Ok(subject);
        }
    }
}
