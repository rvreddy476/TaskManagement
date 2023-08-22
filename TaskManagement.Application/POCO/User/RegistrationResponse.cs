using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Application.POCO.User
{
    public class RegistrationResponse
    {
        public bool IsRegistrationSuccessful { get; set; }
        public ErrorMessage ErrorMessage { get; set; } 

    }
}
