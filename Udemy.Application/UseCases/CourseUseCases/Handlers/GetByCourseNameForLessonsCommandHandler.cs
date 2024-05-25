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
    public class GetByCourseNameForLessonsCommandHandler : IRequestHandler<GetByCourseNameForLessonsCommandQuery, CourseModel>
    {
        private readonly IAppDbContext _appDbContext;

        public GetByCourseNameForLessonsCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<CourseModel> Handle(GetByCourseNameForLessonsCommandQuery request, CancellationToken cancellationToken)
        {
            return await _appDbContext.courses.FirstOrDefaultAsync(x => x.name == request.CourseName);
        }
    }
}
