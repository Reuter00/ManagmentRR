using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagmentRR.Models;

namespace ManagmentRR.Services
{
    public class UserServices
    {
        private readonly ManagmentRRContext _context;

        public UserServices(ManagmentRRContext context)
        {
            _context = context;
        }

        public List<Users> FindUsers()
        {
            return _context.Users.ToList();
        }

    }
}

