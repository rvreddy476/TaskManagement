using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.POCO.User;

namespace TaskManagement.API.Controllers.User
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService) 
        {
            _loginService = loginService;
        }
        [Route("/login")]
        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            return Ok(await _loginService.Login(login));
        }
    }
}
