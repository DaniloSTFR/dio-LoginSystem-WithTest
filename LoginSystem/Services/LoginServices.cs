using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginSystem.Context;

namespace LoginSystem.Services
{
    public class LoginServices
    {
        private readonly ManagerContext _context;

        public LoginServices(ManagerContext context)
        {
            _context = context;
        }
        
    }
}