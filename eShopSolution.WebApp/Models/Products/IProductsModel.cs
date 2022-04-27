using eShopSolution.WebApp.Models.Products.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Models.Products
{
    public interface IProductsModel
    {
        Task<List<Product>> getAllProducts();
        Task<Product> loadProduct(int? id);
        Task createProduct(Product product);
        Task updateProduct(Product product);
        Task deleteProduct(int? id);
    }
}
