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
    public class ExamController : ControllerBase
    {
        private readonly IExamService _examService;
        private readonly IMapper _mapper;

        public ExamController(IExamService examService, IMapper mapper)
        {
            _examService = examService;
            _mapper = mapper;
        }


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
            var examDto = _mapper.Map<ExamDto>(exam);
            return Ok(examDto);
        }

        //[HttpGet("byStudent/{studentId}")]
        //public ActionResult GetByStudentId(int studentId)
        //{
        //    var exam = _examService.GetByStudentId(studentId);
        //    return Ok(exam);
        //}
      
        [HttpGet("{@class}/{title}")]
        public ActionResult GetByStudentId(string @class,string title)
        {
            var list = _examService.GetByClassAndByTitle(@class,title);
            var listDto = _mapper.Map<IEnumerable<ExamDto>>(list);
            return Ok(listDto);
        }
        // POST api/<ExamController>
        [HttpPost]
        public void Post([FromBody] ExamDto newExamDto)
        {
            var newExam = _mapper.Map<Exam>(newExamDto);
            _examService.Add(newExam);
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
