using AutoService.Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Application.UseCases.AnswerUseCases.Queries;
using Udemy.Domain.MODELS;

namespace Udemy.Application.UseCases.AnswerUseCases.Handlers
{
    public class GetByIdAnswerCommandHandler : IRequestHandler<GetByIdAnswerCommandQuery, AnswerModel>
    {
        private readonly IAppDbContext _appDbContext;

        public GetByIdAnswerCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<AnswerModel> Handle(GetByIdAnswerCommandQuery request, CancellationToken cancellationToken)
        {
            return await _appDbContext.answers.FirstOrDefaultAsync(x=> x.Id == request.Id);
        }
    }
}
