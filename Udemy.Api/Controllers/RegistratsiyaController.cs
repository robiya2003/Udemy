
using AutoService.Domain.Entities.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using Udemy.Api.AuthServicess;

using Udemy.Domain.DTOS;
using Udemy.Domain.MODELS;

namespace Udemy.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RegistratsiyaController : ControllerBase
    {
        private readonly UserManager<UserModel> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IAuthService _authService;
        
        public RegistratsiyaController(
            UserManager<UserModel> userManager,
            RoleManager<IdentityRole> roleManager,
            IAuthService authService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _authService = authService;
            
        }
        [HttpPost]
        public async Task<ResponceModel> CreatePersonForUser(UserDto userDto)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception();
            }
            var user=new UserModel()
            {
                UserName=userDto.Username, Email=userDto.Email,
               FirstName=userDto.Firstname, LastName=userDto.Lastname,
              Role="User"
            };

            var result = await _userManager.CreateAsync(user, userDto.Password);

            if (!result.Succeeded)
                throw new Exception();

            await _userManager.AddToRoleAsync(user, "User");

            // Send Email
          

            return new ResponceModel()
            {
                Message="User Created"
            };
        }



        [HttpPost]
        public async Task<ResponceModel> CreatePersonForAdmin(UserDto userDto)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception();
            }
            var user = new UserModel()
            {
                UserName = userDto.Username,
                Email = userDto.Email,
                FirstName = userDto.Firstname,
                LastName = userDto.Lastname,
                Role = "Admin"
            };

            var result = await _userManager.CreateAsync(user, userDto.Password);

            if (!result.Succeeded)
                throw new Exception();

            await _userManager.AddToRoleAsync(user, "Admin");
            return new ResponceModel()
            {
                Message = "Admin Created"
            };
        }
        [HttpPost]
        public async Task<ActionResult<AuthDTO>> LogIn(UserLoginDTO userLoginDTO)
        {
            var user = await _userManager.FindByEmailAsync(userLoginDTO.email);

            if (user is null)
            {
                return Unauthorized("User not Found with this email");
            }

            var test = await _userManager.CheckPasswordAsync(user, userLoginDTO.password);

            if (!test)
            {
                return Unauthorized("Password invalid");
            }

            // token kelishi kere

            var token = await _authService.GenerateToken(user);

            return Ok(token);
        }
    }
}
