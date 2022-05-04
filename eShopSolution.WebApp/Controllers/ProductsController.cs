using eShopSolution.WebApp.Models.Products;
using eShopSolution.WebApp.Models.Products.Schemas;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Controllers
{
    public class ProductsController: Controller
    {
        private readonly IProductsModel _productsModel;
        public ProductsController(IProductsModel productsModel)
        {
            _productsModel = productsModel;
        }
        public async Task<IActionResult> getAll()
        {
            return View(await _productsModel.getAllProducts());
        }
        public async Task<IActionResult> create(int? id)
        {
            if(id == null)
            {
                return View(await _productsModel.loadProduct(id));
            }
            return View("update", await _productsModel.loadProduct(id));
        }
        [HttpPost]
        public async Task<IActionResult> insert(Product product)
        {
            if (ModelState.IsValid)
            {
                await _productsModel.createProduct(product);
                return RedirectToAction("getAll");
            }
            return View("create",product);
        }
        public async Task<IActionResult> update(Product product)
        {
            if (ModelState.IsValid)
            {
                await _productsModel.updateProduct(product);
                return RedirectToAction("getAll");
            }
            return View(product);
        }
        public async Task<IActionResult> delete(int id)
        {
            await _productsModel.deleteProduct(id);
            return View("~/Views/Products/getAll.cshtml", (await _productsModel.getAllProducts()).ToList());
        }

    }
}
