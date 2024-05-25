using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Domain.MODELS;

namespace Udemy.Application.UseCases.PopularTopicUseCases.Queries
{
    public class GetByPopularTopicNameAllCoursesCommandQuery:IRequest<List<CourseModel>>
    {
        public string PopularTopicName { get; set; }
    }
}
