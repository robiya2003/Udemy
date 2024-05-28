
using AutoService.Domain.Entities.Models;
using EmailSenderApp.Application.Services.EmailServces;
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
        private readonly IEmailService _emailService;
        public RegistratsiyaController(
            UserManager<UserModel> userManager,
            RoleManager<IdentityRole> roleManager,
            IAuthService authService,
            IEmailService emailService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _authService = authService;
            _emailService = emailService;
            
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
          EmailModel emailModel = new EmailModel()
          {
              To = userDto.Email,
              Subject="Registratsiya",
              Body="Registratsiyadan muvaqqiyatli otdizngiz"
          };
            await _emailService.SendEmailAsync(emailModel);

            return new ResponceModel()
            {
                Message = $"{_userManager.FindByEmailAsync(userDto.Email).Result.Id}"
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
