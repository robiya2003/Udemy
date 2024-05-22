using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Application.UseCases.CategoryUseCases.Queries
{
   public class GetByCategoryTopicCommandQuery:IRequest<List<string>>
    {
       public string CategoryName {  get; set; }
    }
}
