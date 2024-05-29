using AutoService.Application.Abstractions;
using AutoService.Domain.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<UserModel> _userManager;
        public BuyCourseForUserController(AppDbContext appDbContext,UserManager<UserModel> userManager)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
        }

        [HttpPut]
        public async Task<ResponceModel> BuyCourse(string userId, int courseId)
        {
            try
            {
                // Find the user and course
                var user = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == userId);
                var course = await _appDbContext.courses.FirstOrDefaultAsync(x => x.id == courseId);

                if (user == null || course == null)
                {
                    return new ResponceModel()
                    {
                        Message = "User or course not found",
                       
                    };
                }

                Console.WriteLine(course.name);

                // Add the user to the course
                course.users.Add(user);

                // Update the course
                _appDbContext.courses.Update(course);

                // Save changes
                await _appDbContext.SaveChangesAsync();

                return new ResponceModel()
                {
                    Message = $"{userId} successfully purchased course {courseId}",
                                   };
            }
            catch (Exception ex)
            {
                // Log the exception (not shown here for brevity)
                return new ResponceModel()
                {
                    Message = $"An error occurred: {ex.Message}",
                  
                };
            }
        }

        [HttpGet]
        public async Task<List<CourseModel>> GetAllCoursesForUser(string userid)
        {
            List<CourseModel> result = new List<CourseModel>();
            List<CourseModel> courses = await _appDbContext.courses.ToListAsync();
            foreach (var item in courses)
            {
                foreach (var item1 in item.users)
                {
                    if (item1.Id == userid)
                    {
                        result.Add(item);
                    }
                }
            }
            return result;
        }
    }
}
