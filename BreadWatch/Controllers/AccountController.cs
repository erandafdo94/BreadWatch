using BreadWatch.Dto;
using BreadWatch.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BreadWatch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<ApplicationUser>> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByNameAsync(loginDto.UserName);
            if (user == null || !await _userManager.CheckPasswordAsync(user, loginDto.Password))
                return Unauthorized();

            return user;
        }

        [HttpPost("Register")]
        public async Task<ActionResult> Register(RegisterDto registerDto)
        {
            var user = new ApplicationUser { UserName = registerDto.UserName, Email = registerDto.Email };

            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (!result.Succeeded)
            {
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }

                return ValidationProblem();
            }

            await _userManager.AddToRoleAsync(user, "User");

            return StatusCode(201);
        }
    }
}
