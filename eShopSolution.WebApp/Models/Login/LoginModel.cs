using eShopSolution.Database;
using eShopSolution.WebApp.Commons;
using eShopSolution.WebApp.Models.Login.Schemas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Models.Login
{
    public class LoginModel : ILoginModel
    {
        private readonly eShopContext _context;

        public LoginModel(eShopContext context)
        {
            _context = context;
        }
        public async Task<bool> checkLogin(UserLogin userLogin)
        {
            var user = await _context.User.Where(x => x.Username == userLogin.username).FirstOrDefaultAsync();
            if(user != null)
            {
                if(user.Password == Security.GetMD5(userLogin.password, user.FirstSecurityString, user.LastSecurityString))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
