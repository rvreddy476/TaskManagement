using TaskManagement.Application.POCO.User;

namespace TaskManagement.Application.Interfaces
{
    public interface IUserRegistarionService
    {
        public Task<RegistrationResponse> RegisterUser(Register register);
    }
}
