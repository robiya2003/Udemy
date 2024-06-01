using AutoService.Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Application.UseCases.NewsUseCases.Queries;
using Udemy.Domain.MODELS;

namespace Udemy.Application.UseCases.NewsUseCases.Handlers
{
    public class GetByIdNewsCommandHandler : IRequestHandler<GetByIdNewsCommandQuery, NewsModel>
    {
        private readonly IAppDbContext _appDbContext;
        public GetByIdNewsCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Task<NewsModel> Handle(GetByIdNewsCommandQuery request, CancellationToken cancellationToken)
        {
            return _appDbContext.news.FirstOrDefaultAsync(x=>x.Id == request.Id);
        }
    }
}
