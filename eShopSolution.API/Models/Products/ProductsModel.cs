using eShopSolution.Database;
using eShopSolution.WebApp.Models.Products.Schemas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.API.Models.Products
{
    public class ProductsModel : IProductsModel
    {
        private readonly eShopContext _context;
        public ProductsModel(eShopContext context)
        {
            _context = context;
        }
        public async Task<Product> getProduct(string id)
        {
            return  await _context.Product.Where(x => x.Id.ToString() == id).Select(x => new Product
            {
                Id = x.Id.ToString(),
                Name = x.Name,
                Price = x.Price,
                ViewCount = x.ViewCount
            }).FirstOrDefaultAsync();
        }

        public async Task<List<Product>> getProducts()
        {
            return await _context.Product.Select(x => new Product
            {
                Id = x.Id.ToString(),
                Name = x.Name,
                Price = x.Price,
                ViewCount = x.ViewCount
            }).ToListAsync();
        }
    }
}
