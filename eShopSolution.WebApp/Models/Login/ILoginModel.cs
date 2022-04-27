using eShopSolution.WebApp.Models.Login.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Models.Login
{
    public interface ILoginModel
    {
        Task<bool> checkLogin(UserLogin userLogin);
    }
}
