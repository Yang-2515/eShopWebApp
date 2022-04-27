using eShopSolution.WebApp.Models.Login.Schemas;
using eShopSolution.WebApp.Models.Signup.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Models.Signup
{
    public interface ISignupModel
    {
        Task<UserLogin> Signup(User user);
    }
}
