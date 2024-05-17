using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Udemy.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class AAAAAAController : ControllerBase
    {
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<string> UploadFileAdmin(IFormFile ufile)
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
                return "yaratildi";
            }
            return "yaratilmadi";
        }
        [Authorize(Roles = "User")]
        [HttpPost]
        public async Task<string> UploadFileUser(IFormFile ufile)
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
                return "yaratildi";
            }
            return "yaratilmadi";
        }
    }
}
