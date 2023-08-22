using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.POCO.User;

namespace TaskManagement.API.Controllers.User
{   
    [ApiController]
    public class UserRegistrationController : ControllerBase
    {
        private readonly IUserRegistarionService _userRegistarionService;
        public UserRegistrationController(IUserRegistarionService userRegistarionService) 
        {
            _userRegistarionService = userRegistarionService;
        }
        [Route("/register")]
        [HttpPost]
        public async Task<IActionResult> Register(Register register)
        {
            var response = await _userRegistarionService.RegisterUser(register);

            if (response == null)
            {
                return  StatusCode(StatusCodes.Status500InternalServerError);
            }

            return Ok(response);
        }
    }
}
