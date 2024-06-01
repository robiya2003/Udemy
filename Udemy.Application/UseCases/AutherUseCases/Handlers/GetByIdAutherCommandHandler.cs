using AutoService.Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Application.UseCases.AutherUseCases.Queries;
using Udemy.Domain.MODELS;

namespace Udemy.Application.UseCases.AutherUseCases.Handlers
{
    public class GetByIdAutherCommandHandler : IRequestHandler<GetByIdAutherCommandQuery, AutherModel>
    {
        private readonly IAppDbContext _appDbContext;

        public GetByIdAutherCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<AutherModel> Handle(GetByIdAutherCommandQuery request, CancellationToken cancellationToken)
        {
            return await _appDbContext.authers.FirstOrDefaultAsync(x=>x.id==request.Id);
        }
    }
}
