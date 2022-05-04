using eShopSolution.WebApp.Models.Products.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.API.Models.Products
{
    public interface IProductsModel
    {
        Task<Product> getProduct(string id);
        Task<List<Product>> getProducts();
    }
}
