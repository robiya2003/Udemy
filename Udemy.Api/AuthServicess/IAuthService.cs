using Udemy.Domain.DTOS;
using Udemy.Domain.MODELS;

namespace Udemy.Api.AuthServicess
{
    public interface IAuthService
    {
        public Task<AuthDTO> GenerateToken(UserModel user);
    }
}
