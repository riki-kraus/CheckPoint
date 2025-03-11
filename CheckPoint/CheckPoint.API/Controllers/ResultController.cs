using CheckPoint.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheckPoint.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        private readonly IResultService _resultService;

        // GET: api/<ResultController>
        [HttpGet]
        //public ActionResult Get()
        //{
           
        //}

        // GET api/<ResultController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var res = _resultService.GetById(id);
            return Ok(res);
        }

        [HttpGet("{examId}")]
        public ActionResult GetByExamId(int examId)
        {
            var res = _resultService.GetByExamId(examId);
            return Ok(res);

        }

        // POST api/<ResultController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ResultController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ResultController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
