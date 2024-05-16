using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Domain.DTOS
{
    public class AuthDTO
    {
        public string? Token { get; set; }
        public string? Message { get; set; }
        public int StatusCode { get; set; }
        public bool IsSuccess { get; set; } = false;
    }
}
