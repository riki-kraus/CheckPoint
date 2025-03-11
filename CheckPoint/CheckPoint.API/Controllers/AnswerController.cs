
using CheckPoint.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheckPoint.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerService _answerService;

        // GET: api/<AnswerController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<AnswerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var exam = _answerService.GetAnsById(id);
            return Ok(exam);
        }
        [HttpGet("{examId}")]
        public ActionResult GetAnsByExam(int examId)
        {
            var exam = _answerService.GetAnsByExam(examId);
            return Ok(exam);
        }
        [HttpGet("{examId}/{num}")]
        public ActionResult GetAnsByExamAndNum(int examId,int num)
        {
            var exam = _answerService.GetAnsByExamAndNum(examId, num);
            return Ok(exam);
        }
        // POST api/<AnswerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AnswerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AnswerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
