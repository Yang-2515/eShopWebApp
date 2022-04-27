using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Models.Login.Schemas
{
    public class UserLogin
    {
        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}
