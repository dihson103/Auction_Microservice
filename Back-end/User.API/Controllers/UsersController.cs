using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using User.Application;
using User.Domain;

namespace User.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;

        public UsersController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _service.GetUsers();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult PostUsers([FromBody] UserRequest userRequest)
        {
            _service.AddUser(userRequest);
            return Created($"api/users/{userRequest.Id}", userRequest);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteUsers(string id)
        {
            _service.DeleteUser(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateUser([FromBody] UserUpdateRequest userRequest)
        {
            _service.UpdateUser(userRequest);
            return Ok();
        }

        [HttpPatch]
        public IActionResult ChangePassword([FromBody] ChangePasswordRequest changePasswordRequest)
        {

            return Ok();
        }
    }
}
