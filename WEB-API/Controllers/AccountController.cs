using AutoMapper;
using Business.Concrete;
using Entites.DTOs;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;
        private readonly TokenManager _tokenManager;

        public AccountController(UserManager<User> userManager, IMapper mapper, IConfiguration config, TokenManager tokenManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _config = config;
            _tokenManager = tokenManager;
        }

        // GET: api/<AccountController>

        // POST api/<AccountController>
        [HttpPost("register")]

        public async Task<IActionResult> RegsiterUser([FromBody] RegisterUserDTO userRegister)
        {
            var user = _mapper.Map<User>(userRegister);
            user.UserName = userRegister.Email;
            var result = await _userManager.CreateAsync(user, userRegister.Password);

            if (!result.Succeeded)
            {
                return BadRequest();
            }
            return Ok(new { status = 201, message = "user created" });
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginUser([FromBody] LoginUserDTO userDTO)
        {

            var findUser = await _userManager.FindByEmailAsync(userDTO.Email);
            var checkPass = await _userManager.CheckPasswordAsync(findUser, userDTO.Password);

            if (findUser == null || !checkPass)
            {
                return Unauthorized();

            }
            var token = await _tokenManager.GenerateToken(findUser);
            return Ok(new { email = findUser.Email, token });

        }

        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
