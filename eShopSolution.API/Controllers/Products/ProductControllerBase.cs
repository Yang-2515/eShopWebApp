using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.API.Controllers.Products
{
    public class ProductControllerBase : BaseController
    {
        public ProductControllerBase(IServiceProvider provider) : base(provider)
        {
        }
    }
}
