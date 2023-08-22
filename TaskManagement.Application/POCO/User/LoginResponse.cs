using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Application.POCO.User
{
    public class LoginResponse
    {   
        public bool IsValidUser { get; set; }
        public string AuthToken { get; set; }
        public ErrorMessage ErrorMessage { get; set; }
    }
}
