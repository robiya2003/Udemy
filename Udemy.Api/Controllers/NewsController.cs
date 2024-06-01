using AutoService.Domain.Entities.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Udemy.Application.UseCases.NewsUseCases.Commands;
using Udemy.Application.UseCases.NewsUseCases.Queries;
using Udemy.Domain.DTOS;
using Udemy.Domain.MODELS;

namespace Udemy.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public NewsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ResponceModel> CreateNews(NewsDTO news)
        {
            var fileName = Path.GetFileName(news.imagefile.FileName);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images\news", fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await news.imagefile.CopyToAsync(fileStream);
            }
            CreateNewsCommand command = new CreateNewsCommand()
            {
                PhotoPath = $"https://localhost:7030/images/news/{news.imagefile.FileName}",
                PopularTopicId=news.PopularTopicId,
                Title=news.Title,
                About=news.About,
            };
            return  await _mediator.Send(command);
        }
        [HttpGet]
        public async Task<List<NewsModel>> GetAllNews()
        {
            return await _mediator.Send(new GetAllNewsCommandQuery());
        }
        [HttpGet]
        public async Task<NewsModel> GetById(int id)
        {
            return await _mediator.Send(new GetByNameNewsCommandQuery() { Id=id} );
        }
        [HttpGet]
        public async Task<NewsModel> GetByIdNews(int id)
        {
            return await _mediator.Send(new GetByIdNewsCommandQuery() { Id=id});
        }
        [HttpPut]
        public async Task<ResponceModel> UpdateNews(NewsUDTO news)
        {
            var fileName = Path.GetFileName(news.imagefile.FileName);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images\news", fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await news.imagefile.CopyToAsync(fileStream);
            }
            UpdateNewsCommand command = new UpdateNewsCommand()
            {
                Id = news.Id,
                About = news.About,
                Title = news.Title,
                PopularTopicId = news.PopularTopicId,
                PhotoPath = $"https://localhost:7030/images/news/{news.imagefile.FileName}",

            };
            return await _mediator.Send(command);
        }
        [HttpDelete]
        public async Task<ResponceModel> DeleteNews(int id)
        {
            return await _mediator.Send(new DeleteNewsCommand() { Id=id});
        }
    }
}
