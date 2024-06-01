﻿
using AutoMapper;
using AutoService.Domain.Entities.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Udemy.Application.UseCases.CourseUseCases.Commands;
using Udemy.Application.UseCases.CourseUseCases.Queries;
using Udemy.Domain.DTOS;
using Udemy.Domain.MODELS;

namespace Udemy.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CourseController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ResponceModel> CreateCourse(CourseDTO model)
        {
            var fileName = Path.GetFileName(model.imagefile.FileName);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images\courses", fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await model.imagefile.CopyToAsync(fileStream);
            }
            CreateCourseCommand command= new CreateCourseCommand()
            {
                PopularTopicId=model.PopularTopicId,
                name=model.name,
                description=model.description,
                AutherId=model.AutherId,
                PhotoPath= $"https://localhost:7030/images/courses/{model.imagefile.FileName}",
            };
            return await _mediator.Send(command);
        }
        // course namega kora CourseModelnni olish
        [HttpGet]
        public async Task<CourseModel> GetCourseLessons(string name)
        {
            return await _mediator.Send(new GetByCourseNameForLessonsCommandQuery(){CourseName=name });
        }
        [HttpGet]
        public async Task<List<CourseModel>> GetAllCouses()
        {
            return await _mediator.Send(new GetAllCourseCommandQuery()); 
        }
        [HttpGet]
        public async Task<CourseModel> GetByIdCourse(int courseId)
        {
            return await _mediator.Send(new GetByIdCourseCommandQuery() { Id=courseId});
        }
        [HttpPut]
        public async Task<ResponceModel> UpdateCourse(CourseUDTO model)
        {
            var fileName = Path.GetFileName(model.imagefile.FileName);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images\courses", fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await model.imagefile.CopyToAsync(fileStream);
            }
            UpdateCourseCommand command = new UpdateCourseCommand()
            {
                Id=model.Id,
                PopularTopicId = model.PopularTopicId,
                name = model.name,
                description = model.description,
                AutherId = model.AutherId,
                PhotoPath = $"https://localhost:7030/images/courses/{model.imagefile.FileName}",
            };
            return await _mediator.Send(command);
        }
        [HttpDelete]
        public async Task<ResponceModel> DeleteCourse(int id)
        {
            return await _mediator.Send(new DeleteCourseCommand() { Id=id});
        }
    }
}
