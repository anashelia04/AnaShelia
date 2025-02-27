using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Model;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly IValidator<User> _validator;

        public UserController(UserService userService, IValidator<User> validator)
        {
            _userService = userService;
            _validator = validator;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            var validationResult = await _validator.ValidateAsync(user);
            if (!validationResult.IsValid)
            {
                return BadRequest(new { status = 400, message = "Validation failed.", errors = validationResult.Errors.Select(e => e.ErrorMessage) });
            }
            _userService.AddUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetUser(id);
            return user is null ? NotFound() : Ok(user);
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(_userService.GetAllUsers());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] User updatedUser)
        {
            var validationResult = await _validator.ValidateAsync(updatedUser);
            if (!validationResult.IsValid)
            {
                return BadRequest(new { status = 400, message = "Validation failed.", errors = validationResult.Errors.Select(e => e.ErrorMessage) });
            }
            _userService.UpdateUser(id, updatedUser);
            return Ok(updatedUser);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var deleted = _userService.DeleteUser(id);
            return deleted ? Ok() : NotFound();
        }
    }

}
