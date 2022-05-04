using eShopSolution.WebApp.Models.Login;
using eShopSolution.WebApp.Models.Login.Schemas;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginModel _loginModel;
        public LoginController(ILoginModel loginModel)
        {
            _loginModel = loginModel;
        }
            public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> checkLogin(UserLogin userLogin)
        {
            if (await _loginModel.checkLogin(userLogin))
            {
                return RedirectToActionPreserveMethod("UserPage","Home",userLogin.username, "true");
            }
            return View("Index");
        }
    }
}
