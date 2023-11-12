using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginSystem.Context;

namespace LoginSystem.Services
{
    public class UserServices
    {
        private readonly ManagerContext _context;

        public UserServices(ManagerContext context)
        {
            _context = context;
        }

        //createUser
        //updateUser
        //readUserID-Email
        //readUserList-Nome
        //deleteUser
    }
}