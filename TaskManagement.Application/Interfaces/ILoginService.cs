using TaskManagement.Application.POCO.User;

namespace TaskManagement.Application.Interfaces
{
    public interface ILoginService
    {
        public Task<LoginResponse> Login(Login login);
    }
}
