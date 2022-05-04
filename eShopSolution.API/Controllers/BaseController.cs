using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;


namespace eShopSolution.API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
    [ProducesResponseType((int)HttpStatusCode.NotAcceptable)]
    public class BaseController : ControllerBase
    {
        protected readonly ILogger<BaseController> _logger;

        public BaseController()
        {
        }

        public BaseController(
            IServiceProvider provider
        )
        {
        }
    }
}
