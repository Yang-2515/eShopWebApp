using eShopSolution.WebApp.Models.Signup;
using eShopSolution.WebApp.Models.Signup.Schemas;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Controllers
{
    public class SignupController : Controller
    {
        private readonly ISignupModel _signupModel;
        public SignupController(ISignupModel signupModel)
        {
            _signupModel = signupModel;
        }
        public IActionResult Init()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> signup(User user)
        {

            return View("SigupLogin", await _signupModel.Signup(user));
        }
    }
}
