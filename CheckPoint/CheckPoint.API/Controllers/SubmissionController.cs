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
    public class SubmissionController : ControllerBase
    {
        private readonly ISubmissionService _SubmissionService;
        private readonly IMapper _mapper;

        public SubmissionController(ISubmissionService submissionService, IMapper mapper)
        {
            _SubmissionService = submissionService;
            _mapper = mapper;
        }



        // GET: api/<SubmissionController>
        //[HttpGet]
        //public ActionSubmission Get()
        //{

        //}

        // GET api/<SubmissionController>/5
        [HttpGet("id/{id}")]
        public ActionResult Get(int id)
        {
            var submission = _SubmissionService.GetById(id);
            var submissionDto = _mapper.Map<SubmissionDto>(submission);
            return Ok(submissionDto);
        }

        [HttpGet("examId/{examId}")]
        public ActionResult GetByExamId(int examId)
        {
            var list = _SubmissionService.GetByExamId(examId);
            var listDto = _mapper.Map<IEnumerable<SubmissionDto>>(list);
            return Ok(listDto);

        }

        // POST api/<SubmissionController>
        [HttpPost]
        public void Post([FromBody] SubmissionDto newSubmissionDto)
        {
            var newSubmission = _mapper.Map<Submission>(newSubmissionDto);
            _SubmissionService.Add(newSubmission);
        }

        // PUT api/<SubmissionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SubmissionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
