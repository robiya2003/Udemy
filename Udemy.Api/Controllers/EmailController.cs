﻿using EmailSenderApp.Application.Services.EmailServces;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Udemy.Domain.MODELS;

namespace EmailSenderApp.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail([FromBody] EmailModel model)
        {
            
            await _emailService.SendEmailAsync(model);  

            return Ok("Muvoffaqiyatli email yuborildi");
        }
    }
}
