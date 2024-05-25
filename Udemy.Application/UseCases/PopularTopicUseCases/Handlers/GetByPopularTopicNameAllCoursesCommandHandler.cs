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
using Vit.Extensions.Object_Extensions;

namespace Udemy.Application.UseCases.PopularTopicUseCases.Handlers
{
    public class GetByPopularTopicNameAllCoursesCommandHandler : IRequestHandler<GetByPopularTopicNameAllCoursesCommandQuery, List<CourseModel>>
    {
        private readonly IAppDbContext _appDbContext;

        public GetByPopularTopicNameAllCoursesCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<CourseModel>> Handle(GetByPopularTopicNameAllCoursesCommandQuery request, CancellationToken cancellationToken)
        {
            var lst = _appDbContext.popularTopics.FirstOrDefaultAsync(x => x.Name == request.PopularTopicName).Result.courses;
            foreach (var item in lst)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.popularTopic.Name);
            }
            return lst;
        }
    }
}
