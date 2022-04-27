using eShopSolution.WebApp.Models.Login.Schemas;
using eShopSolution.WebApp.Models.Signup.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using TblUser = eShopSolution.Database.Entities.User;
using System.Threading.Tasks;
using eShopSolution.WebApp.Commons;
using eShopSolution.Database;

namespace eShopSolution.WebApp.Models.Signup
{
    public class SignupModel : ISignupModel
    {
        private readonly eShopContext _context;
        public SignupModel(eShopContext context)
        {
            _context = context;
        }
        public async Task<UserLogin> Signup(User user)
        {
            UserLogin userLogin = new UserLogin();
            TblUser tbluser = new TblUser();
            tbluser.Username = user.username;
            tbluser.Email = user.email;
            tbluser.Phone = user.phone;

            //pass
            string render = Helpers.RenderToken(user.username, 30);
            tbluser.FirstSecurityString = render.Substring(0, 7);
            tbluser.LastSecurityString = render.Substring(10, 7);
            tbluser.Password = Security.GetMD5(user.password, tbluser.FirstSecurityString, tbluser.LastSecurityString);

            tbluser.RoleId = 2;
            _context.User.Add(tbluser);
            await _context.SaveChangesAsync();

            userLogin.username = user.username;
            userLogin.password = user.password;

            return userLogin;
        }
    }
}
