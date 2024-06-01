using AutoService.Domain.Entities.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Udemy.Application.UseCases.LessonUseCases.Commands;
using Udemy.Application.UseCases.LessonUseCases.Queries;
using Udemy.Domain.DTOS;
using Udemy.Domain.MODELS;

namespace Udemy.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LessonController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ResponceModel> CreateLesson(LessonDTO lesson)
        {
            var fileNameimage = Path.GetFileName(lesson.imagefile.FileName);
            var filePathimage = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images\lessons", fileNameimage);
            using (var fileStream = new FileStream(filePathimage, FileMode.Create))
            {
                await lesson.imagefile.CopyToAsync(fileStream);
            }



            var fileNamevideo = Path.GetFileName(lesson.videofile.FileName);
            var filePathvideo = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\LessonVideoPath", fileNamevideo);
            using (var fileStream = new FileStream(filePathvideo, FileMode.Create))
            {
                await lesson.videofile.CopyToAsync(fileStream);
            }


            CreateLessonCommand command= new CreateLessonCommand()
            {
                CourseId=lesson.CourseId,
                name=lesson.name,
                description=lesson.description,
                VideoPath=filePathimage,
                PhotoPath=filePathvideo,
            };
            return await _mediator.Send(command);
        }
        [HttpGet]
        public async Task<List<LessonModel>> GetAllLessons()
        {
            return await _mediator.Send(new GetAllLessonCommandQuery ());
        }
        [HttpGet] 
        public async Task<LessonModel> GetByIdLesson(int Id)
        {
            return await _mediator.Send(new GetByIdLessonCommandQuery { Id = Id });
        }
        [HttpPut]
        public async Task<ResponceModel> UpdateLesson(LessonUDTO lesson)
        {
            var fileNameimage = Path.GetFileName(lesson.imagefile.FileName);
            var filePathimage = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images\lessons", fileNameimage);
            using (var fileStream = new FileStream(filePathimage, FileMode.Create))
            {
                await lesson.imagefile.CopyToAsync(fileStream);
            }



            var fileNamevideo = Path.GetFileName(lesson.videofile.FileName);
            var filePathvideo = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\LessonVideoPath", fileNamevideo);
            using (var fileStream = new FileStream(filePathvideo, FileMode.Create))
            {
                await lesson.videofile.CopyToAsync(fileStream);
            }
            UpdateLessonCommand command = new UpdateLessonCommand()
            {
                CourseId = lesson.CourseId,
                name = lesson.name,
                description = lesson.description,
                VideoPath = filePathvideo,
                PhotoPath = filePathimage,
                id=lesson.id
            };
            return await _mediator.Send(command);
        }
        [HttpDelete]
        public async Task<ResponceModel> DeleteLesson(int id)
        {
            return await _mediator.Send(new DeleteLessonCommand() { Id=id});
        }
    }
}
