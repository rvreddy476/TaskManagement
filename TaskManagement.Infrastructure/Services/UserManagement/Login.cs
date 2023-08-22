using Microsoft.AspNet.Identity.EntityFramework;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.POCO.User;
using Microsoft.AspNetCore.Identity;

namespace TaskManagement.Infrastructure.Services.UserManagement
{
    public class LoginService : ILoginService
    {
        private readonly SignInManager<IdentityUser> _signInManager;
       
        public LoginService(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<LoginResponse> Login(Login login)
        {
            var signInResult =await _signInManager.PasswordSignInAsync(new IdentityUser
            {
                UserName = login.UserName
            }, login.Password, true, false);

            if (signInResult.Succeeded)            
                return new LoginResponse
                {
                    IsValidUser = true,
                };
            
            else
            return new LoginResponse { IsValidUser = false };
        }


    }

}
