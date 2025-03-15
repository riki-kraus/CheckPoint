using CheckPoint.Core.Entities;
using CheckPoint.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheckPoint.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public ActionResult Get()
        {
            var list = _studentService.GetAll();
            return Ok(list);
        }

        // GET api/<StudentController>/5
        [HttpGet("id/{id}")]
        public Student Get(int id)
        {
            return _studentService.GetById(id);
        }
        [HttpGet("name/{name}")]
        public Student Get(string name)
        {
            return _studentService.GetByName(name);
        }
        [HttpGet("class/{class}")]
        public ActionResult GetByClass(string @class)
        {
           var list= _studentService.GetByClass(@class);
            return Ok(list);
        }
        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] Student student)
        {
            _studentService.Add(student);
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
