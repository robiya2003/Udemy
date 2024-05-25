using AutoService.Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Application.UseCases.CategoryUseCases.Queries;
using Udemy.Domain.MODELS;

namespace Udemy.Application.UseCases.CategoryUseCases.Handlers
{
    public class GetByCategoryTopicCommandhandler : IRequestHandler<GetByCategoryTopicCommandQuery, List<TopicModel>>
    {
        private readonly IAppDbContext _appDbContext;
        public GetByCategoryTopicCommandhandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<TopicModel>> Handle(GetByCategoryTopicCommandQuery request, CancellationToken cancellationToken)
        {
            var categories = await _appDbContext.categories.ToListAsync();
            List<TopicModel> result=new List<TopicModel>();
            foreach (var category in categories)
            {
                if(category.Name == request.CategoryName)
                {
                    result=category.Topics.ToList();
                }
            }
            return result;
        }
    }
}
