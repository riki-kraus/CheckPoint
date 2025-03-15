using CheckPoint.Core.Entities;
using CheckPoint.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheckPoint.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
       public UserController(IUserService userService)
        {
            this._userService = userService;
        }
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult Get()
        {

            var list = _userService.GetAll();
            return Ok(list);

        }
       

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {

            var user = _userService.GetUserById(id);
            return Ok(user);
        }
        // GET api/<UserController>/5
        [HttpGet("{@class}")]
        public ActionResult Get(string @class)
        {

            var list = _userService.GetUsersByClass(@class);
            return Ok(list);
        }
        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] User value)
        {
            _userService.Add(value);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
