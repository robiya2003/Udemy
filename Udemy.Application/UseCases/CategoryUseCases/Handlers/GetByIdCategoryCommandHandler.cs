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
    public class GetByIdCategoryCommandHandler : IRequestHandler<GetByIdCategoryCommandQuery, CategoryModel>
    {
        private readonly IAppDbContext _appDbContext;
        public GetByIdCategoryCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<CategoryModel> Handle(GetByIdCategoryCommandQuery request, CancellationToken cancellationToken)
        {
            return await _appDbContext.categories.FirstOrDefaultAsync(x=> x.Id == request.Id);    
        }
    }
}
