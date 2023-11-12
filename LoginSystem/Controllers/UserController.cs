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
    public class UserController : ControllerBase
    {
        private readonly UserServices _user;

        public UserController(UserServices user)
        {
            _user = user;
        }
        
    }
}