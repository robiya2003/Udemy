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
    public class GetByTopicNamePopularTopicListCommandHandler : IRequestHandler<GetByTopicNamePopularTopicListCommandQuery, List<PopularTopicModel>>
    {
        private readonly IAppDbContext _appDbContext;

        public GetByTopicNamePopularTopicListCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<PopularTopicModel>> Handle(GetByTopicNamePopularTopicListCommandQuery request, CancellationToken cancellationToken)
        {
            return _appDbContext.topic.FirstOrDefaultAsync(x => x.Name == request.TopicName).Result.PopularTopics;
        }
    }
}
