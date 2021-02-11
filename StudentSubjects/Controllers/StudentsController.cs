using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSubjects.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public StudentsController(IRepositoryManager repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = _repository.Student.GetAllStudents(false);//query is sneller wanneer trackchanges af staat
            return Ok(students); //status OK = code 200       
        }
        [HttpGet("{id}")]
        public IActionResult GetStudent(Guid id)
        {
            var student = _repository.Student.GetStudent(id, false);
            if (student == null)
            {
                return NotFound(); //HTTP Response met status code 404 -- not found 
            }
            return Ok(student); //HTTP Response met status code 200 --OK
        }
    }
}
