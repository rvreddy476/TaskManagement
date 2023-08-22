using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.POCO.User;

namespace TaskManagement.Infrastructure.Services.UserManagement
{
    public class UserRegistarionService : IUserRegistarionService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserRegistarionService(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<RegistrationResponse> RegisterUser(Register register)
        {
            var user = await _userManager.FindByEmailAsync(register.Email);

            if (user != null)
            {
                return new RegistrationResponse
                {
                    ErrorMessage = new ErrorMessage
                    {
                        Message = "user already exist"
                    }

                };
            }

            var identityUser = await _userManager.CreateAsync(new IdentityUser
            {
                Email = register.Email,
                UserName = register.UserName
            }, register.Password);

            if (identityUser != null)
            {
                return new RegistrationResponse
                {
                    ErrorMessage = new ErrorMessage
                    {
                        Message = "User registered successfully"
                    }
                };
            }

            return null;
        }
    }
}
