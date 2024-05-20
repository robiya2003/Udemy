
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Domain.MODELS;

namespace EmailSenderApp.Application.Services.EmailServces
{
    public interface IEmailService
    {
        public Task SendEmailAsync(EmailModel model);
    }
}
