using AutoService.Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Application.UseCases.PopularTopicUseCases.Queries;
using Udemy.Domain.MODELS;

namespace Udemy.Application.UseCases.PopularTopicUseCases.Handlers
{
    public class GetByIdPopularTopicCommandHandler : IRequestHandler<GetByIdPopularTopicCommandQuery, PopularTopicModel>
    {
        private readonly IAppDbContext _appDbContext;

        public GetByIdPopularTopicCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Task<PopularTopicModel> Handle(GetByIdPopularTopicCommandQuery request, CancellationToken cancellationToken)
        {
            return _appDbContext.popularTopics.FirstOrDefaultAsync(x=> x.Id == request.Id);
        }
    }
}
