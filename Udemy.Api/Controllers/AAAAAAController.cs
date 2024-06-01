using AutoService.Application.Abstractions;
using AutoService.Domain.Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Udemy.Domain.MODELS;

namespace Udemy.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    
    public class AAAAAAController : ControllerBase
    {
        private readonly IAppDbContext _appDbContext;

        public AAAAAAController(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        
        
        [HttpPost]
        public async Task<ResponceModel> UploadFileAdmin(IFormFile ufile)
        {
            if (ufile != null && ufile.Length > 0)
            {
                var fileName = Path.GetFileName(ufile.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images", fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await ufile.CopyToAsync(fileStream);
                }
                Console.WriteLine(filePath);
                return new ResponceModel
                {
                    Message="yaratildu"
                };
            }
            return new ResponceModel
            {
                Message = "yaratilmadi"
            };
        }
        
        
    }
}
