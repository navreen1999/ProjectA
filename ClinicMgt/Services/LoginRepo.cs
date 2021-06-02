using ClinicMgt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicMgt.Services
{
    public class LoginRepo:ILogin<User>
    {
        private ClinicContext _context;


        public LoginRepo(ClinicContext context)
        {
            _context = context;

        }
        public bool Login(User t)
        {
            try
            {
                User user = _context.Users.SingleOrDefault(a => a.Username == t.Username);
                if (user.Password == t.Password)
                    return true;
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }
    }
}

