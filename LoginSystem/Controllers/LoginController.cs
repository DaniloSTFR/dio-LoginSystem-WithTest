using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoginSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        
        private readonly LoginServices _login;

        public LoginController(LoginServices login)
        {
            _login = login;
        }
    }
}