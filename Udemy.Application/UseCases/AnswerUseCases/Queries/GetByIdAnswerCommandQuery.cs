﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Domain.MODELS;

namespace Udemy.Application.UseCases.AnswerUseCases.Queries
{
    public class GetByIdAnswerCommandQuery:IRequest<AnswerModel>
    {
        public int Id { get; set; }
    }
}
