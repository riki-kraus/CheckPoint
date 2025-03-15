
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
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerService _answerService;
        private readonly IMapper _mapper;

        public AnswerController(IAnswerService answerService, IMapper mapper)
        {
            _answerService = answerService;
            _mapper = mapper;
        }



        // GET: api/<AnswerController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<AnswerController>/5
        [HttpGet("id/{id}")]
        public ActionResult Get(int id)
        {
            
            var answer = _answerService.GetAnsById(id);
            var answerDto = _mapper.Map<AnswerDto>(answer);
            return Ok(answerDto);
        }

        [HttpGet("examId/{examId}")]
        public ActionResult GetAnsByExam(int examId)
        {
            var list = _answerService.GetAnsByExam(examId);
            var listDto = _mapper.Map<IEnumerable<UserDto>>(list);
            return Ok(listDto);
         

        }
        [HttpGet("{examId}/{num}")]
        public ActionResult GetAnsByExamAndNum(int examId,int num)
        {
            var list = _answerService.GetAnsByExamAndNum(examId, num);
            var listDto = _mapper.Map<IEnumerable<UserDto>>(list);
            return Ok(listDto);
           
        }
        // POST api/<AnswerController>
        [HttpPost]
        public void Post([FromBody] AnswerDto newAnswerDto)
        {
            var newAnswer = _mapper.Map<Answer>(newAnswerDto);
            _answerService.Add(newAnswer);
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
