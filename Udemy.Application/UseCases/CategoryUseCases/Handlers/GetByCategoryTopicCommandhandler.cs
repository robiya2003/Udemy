using AutoService.Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Application.UseCases.CategoryUseCases.Queries;

namespace Udemy.Application.UseCases.CategoryUseCases.Handlers
{
    public class GetByCategoryTopicCommandhandler : IRequestHandler<GetByCategoryTopicCommandQuery, List<string>>
    {
        private readonly IAppDbContext _appDbContext;
        public GetByCategoryTopicCommandhandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<string>> Handle(GetByCategoryTopicCommandQuery request, CancellationToken cancellationToken)
        {
            var topics=await _appDbContext.topic.ToListAsync();
            List<string> result = new List<string>();
            foreach (var topic in topics)
            {
                if(topic.Category.Name==request.CategoryName)
                {
                    result.Add(topic.Name);
                }
            }
            return result;
        }
    }
}
