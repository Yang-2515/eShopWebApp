using eShopSolution.API.Models.Products;
using eShopSolution.WebApp.Models.Products.Schemas;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace eShopSolution.API.Controllers.Products
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ProductControllerBase
    {
        private readonly IProductsModel _iproductsModel;
        public ProductsController(IProductsModel iproductsModel,
            IServiceProvider provider
        ) : base(provider)
        {
            _iproductsModel = iproductsModel ?? throw new ArgumentNullException(nameof(iproductsModel));
        }
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Product), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> getProduct([FromRoute] string id)
        {
            try
            {
                var product = await _iproductsModel.getProduct(id);
                if(product == null)
                {
                    return NotFound();
                }
                return Ok(await _iproductsModel.getProduct(id));
            }
            catch(Exception e)
            {
                return StatusCode(500, new { Error = e.Message });
            }
        }
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Product>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> getProducts()
        {
            try
            {
                return Ok(await _iproductsModel.getProducts());
            }
            catch (Exception e)
            {
                return StatusCode(500, new { Error = e.Message });
            }
        }
    }
}
