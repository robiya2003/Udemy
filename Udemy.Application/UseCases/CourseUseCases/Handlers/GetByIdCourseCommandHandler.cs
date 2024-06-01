using AutoService.Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Application.UseCases.CourseUseCases.Queries;
using Udemy.Domain.MODELS;

namespace Udemy.Application.UseCases.CourseUseCases.Handlers
{
    public class GetByIdCourseCommandHandler : IRequestHandler<GetByIdCourseCommandQuery, CourseModel>
    {
        private readonly IAppDbContext _appDbContext;
        public GetByIdCourseCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public  async Task<CourseModel> Handle(GetByIdCourseCommandQuery request, CancellationToken cancellationToken)
        {
            return await _appDbContext.courses.FirstOrDefaultAsync(x=>x.id==request.Id);
        }
    }
}
