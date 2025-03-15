using AutoMapper;
using CheckPoint.Core.Entities;
using CheckPoint.Core.Services;
using CheckPoint.Service;
using ExamAI.Core.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheckPoint.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentController(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }



        // GET: api/<StudentController>
        [HttpGet]
        public ActionResult Get()
        {
            var list = _studentService.GetAll();
            var listDto= _mapper.Map<IEnumerable<StudentDto>>(list);
            return Ok(listDto);
        }

        // GET api/<StudentController>/5
        [HttpGet("id/{id}")]
        public ActionResult Get(int id)
        { var student= _studentService.GetById(id);
            var studentDto= _mapper.Map<StudentDto>(student);
            return Ok(studentDto);
        }
        //[HttpGet("name/{name}")]
        //public ActionResult Get(string name)
        //{
        //   var student= _studentService.GetByName(name);

        //}
        [HttpGet("class/{class}")]
        public ActionResult GetByClass(string @class)
        {
           var list= _studentService.GetByClass(@class);
            var listDto = _mapper.Map<IEnumerable<StudentDto>>(list);
            return Ok(listDto);
        }
        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] StudentDto newStudentDto)
        {
            var newStudent= _mapper.Map<Student>(newStudentDto);
            _studentService.Add(newStudent);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
