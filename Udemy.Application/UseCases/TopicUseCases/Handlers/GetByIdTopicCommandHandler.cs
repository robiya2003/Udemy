using AutoService.Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Application.UseCases.TopicUseCases.Queries;
using Udemy.Domain.MODELS;

namespace Udemy.Application.UseCases.TopicUseCases.Handlers
{
    public class GetByIdTopicCommandHandler : IRequestHandler<GetByIdTopicCommandQuery, TopicModel>
    {
        private readonly IAppDbContext _appDbContext;
        public GetByIdTopicCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Task<TopicModel> Handle(GetByIdTopicCommandQuery request, CancellationToken cancellationToken)
        {
            return _appDbContext.topic.FirstOrDefaultAsync(x=>x.Id== request.Id);
        }
    }
}
