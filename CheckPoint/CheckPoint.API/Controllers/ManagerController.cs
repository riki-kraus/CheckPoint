using AutoMapper;
using CheckPoint.Core.Entities;
using CheckPoint.Core.Services;
using CheckPoint.Service;
using ExamAI.Core.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheckPoint.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly IManagerService _managerService;
        private readonly IMapper _mapper;

        public ManagerController(IManagerService managerService, IMapper mapper)
        {
            _managerService = managerService;
            _mapper = mapper;
        }


        // GET: api/<ManagerController>
        [HttpGet]
        public ActionResult Get()
        {
            var list=_managerService.GetAll();
            var listDto = _mapper.Map<IEnumerable<ManagerDto>>(list);
            return Ok(list);
        }

        // GET api/<ManagerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var manager= _managerService.GetById(id);
            var managerDto= _mapper.Map<ManagerDto>(manager);
            return Ok(managerDto);

        }

        // POST api/<ManagerController>
        [HttpPost]
        public void Post([FromBody] ManagerDto newManagerDto)
        {
            var newManager = _mapper.Map<Manager>(newManagerDto);
            _managerService.Add(newManager);
        }

        // PUT api/<ManagerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ManagerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
