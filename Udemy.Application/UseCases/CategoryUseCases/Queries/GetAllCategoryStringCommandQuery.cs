using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Application.UseCases.CategoryUseCases.Queries
{
    public class GetAllCategoryStringCommandQuery:IRequest<List<string>>
    {
    }
}
