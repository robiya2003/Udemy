using AutoService.Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Application.UseCases.LessonUseCases.Queries;
using Udemy.Domain.MODELS;

namespace Udemy.Application.UseCases.LessonUseCases.Handlers
{
    public class GetByIdLessonCommandHandler : IRequestHandler<GetByIdLessonCommandQuery, LessonModel>
    {
        private readonly IAppDbContext _appDbContext;

        public GetByIdLessonCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Task<LessonModel> Handle(GetByIdLessonCommandQuery request, CancellationToken cancellationToken)
        {
            return _appDbContext.lessons.FirstOrDefaultAsync(x=>x.id == request.Id);
        }
    }
}
