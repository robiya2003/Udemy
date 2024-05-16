using AutoService.Application.Abstractions;
using AutoService.Domain.Entities.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Application.UseCases.AnswerUseCases.Commands;
using Udemy.Domain.MODELS;

namespace Udemy.Application.UseCases.AnswerUseCases.Handlers
{
    public class CreateAnswerCommandHandler:IRequestHandler<CreateAnswerCommand,ResponceModel>
    {
        private readonly IAppDbContext _appDbContext;
        public CreateAnswerCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<ResponceModel> Handle(CreateAnswerCommand request, CancellationToken cancellationToken)
        {
            var answer = new AnswerModel()
            {
                Title = request.Title,
                Body = request.Body,
                Course=_appDbContext.courses.FirstOrDefaultAsync(x=>x.id == request.CourseId).Result
            };
            _appDbContext.answers.Add(answer);
            _appDbContext.SaveChangesAsync();
            return new ResponceModel()
            {
                Message="Create answer"
            };
        }
    }
}
