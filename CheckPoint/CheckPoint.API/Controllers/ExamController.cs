using CheckPoint.Core.Entities;
using CheckPoint.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheckPoint.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IExamService _examService;

        // GET: api/<ExamController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<ExamController>/5
        [HttpGet("byId/{id}")]
        public ActionResult Get(int id)
        {
            var exam = _examService.GetById(id);
            return Ok(exam);
        }

        [HttpGet("byStudent/{studentId}")]
        public ActionResult GetByStudentId(int studentId)
        {
            var exam = _examService.GetByStudentId(studentId);
            return Ok(exam);
        }
      
        [HttpGet("{@class}/{title}")]
        public ActionResult GetByStudentId(string @class,string title)
        {
            var list = _examService.GetByClassAndByTitle(@class,title);
            return Ok(list);
        }
        // POST api/<ExamController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExamController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExamController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
