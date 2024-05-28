using AutoService.Application.Abstractions;
using AutoService.Domain.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Udemy.Domain.MODELS;
using Udemy.Infastucture.Persistants;

namespace Udemy.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BuyCourseForUserController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        
        public BuyCourseForUserController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPut]
        public async Task<ResponceModel> BuyCourse(string UserId,int courseId)
        {
            UserModel user= await _appDbContext.Users.FirstOrDefaultAsync(x=>x.Id==UserId);
            CourseModel course=await _appDbContext.courses.FirstOrDefaultAsync(x=>x.id == courseId);
            course.users.Add(user);
            _appDbContext.courses.UpdateRange(course);
            _appDbContext.SaveChangesAsync();
            _appDbContext.courses.FirstOrDefaultAsync(x=>x.id==courseId);
            foreach(var item in course.users)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.UserName);
                Console.WriteLine(item.Email);
            }
            return new ResponceModel()
            {
                Message=$"{UserId} chi user {courseId} ni sotib oldi"
            };
        }
    }
}
