using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Domain.MODELS;

namespace Udemy.Application.UseCases.CategoryUseCases.Queries
{
    public class GetByIdCategoryCommandQuery:IRequest<CategoryModel>
    {
        public int Id { get; set; }
    }
}
