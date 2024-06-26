﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Domain.MODELS;

namespace Udemy.Application.UseCases.TopicUseCases.Queries
{
    public class GetByNameTopicCommandQuery:IRequest<TopicModel>
    {
        public string TopicName { get; set; }
    }
}
