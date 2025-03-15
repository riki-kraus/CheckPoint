using CheckPoint.Core.Entities;
using CheckPoint.Core.Services;
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
        public ManagerController(IManagerService managerService)
        {
            _managerService = managerService;
        }
        // GET: api/<ManagerController>
        [HttpGet]
        public ActionResult Get()
        {
            var list=_managerService.GetAll();
            return Ok(list);
        }

        // GET api/<ManagerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var manager= _managerService.GetById(id);
            return Ok(manager);

        }

        // POST api/<ManagerController>
        [HttpPost]
        public void Post([FromBody] Manager manager)
        {
            _managerService.Add(manager);
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
