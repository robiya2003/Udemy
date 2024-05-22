using AutoService.Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Application.UseCases.CategoryUseCases.Queries;
using Udemy.Domain.MODELS;

namespace Udemy.Application.UseCases.CategoryUseCases.Handlers
{
    public class GetAllCategoryStringCommandhandler : IRequestHandler<GetAllCategoryStringCommandQuery, List<string>>
    {
        private readonly IAppDbContext _appDbContext;
        public GetAllCategoryStringCommandhandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<string>> Handle(GetAllCategoryStringCommandQuery request, CancellationToken cancellationToken)
        {
            List<string> result = new List<string>();
            List<CategoryModel> categories=await _appDbContext.categories.ToListAsync(cancellationToken);
            for (int i = 0; i < categories.Count; i++)
            {
                result.Add(categories[i].Name);
            }
            return result;
        }
    }
}
