using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Domain.MODELS;

namespace Udemy.Application.UseCases.NewsUseCases.Queries
{
    public class GetByNameNewsCommandQuery:IRequest<NewsModel>
    {
        public int Id { get; set; }
    }
}
