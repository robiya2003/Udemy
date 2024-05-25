using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Domain.MODELS;

namespace Udemy.Application.UseCases.TopicUseCases.Queries
{
    public class GetByTopicNamePopularTopicListCommandQuery:IRequest<List<PopularTopicModel>>
    {
        public string TopicName { get; set;}
    }
}
