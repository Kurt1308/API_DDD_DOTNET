using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.Services.User;
using Domain.Repository;

namespace Service.Services
{
    public class LoginService : ILoginService
    {
        private IUserRepository _repository;

        public LoginService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<object> FindByLogin(LoginDTO user)
        {
            var baseUser = new UserEntity();
            if(user != null && !string.IsNullOrWhiteSpace(user.Email))
            {
                baseUser = await _repository.FindByLogin(user.Email);
                if(baseUser == null)
                {
                    return null;
                }
                else
                {
                    return baseUser;
                }
            } else
            {
                return null;
            }
        }
    }
}
