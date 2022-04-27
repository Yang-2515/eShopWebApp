using eShopSolution.WebApp.Models.Products.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.Database;
using Microsoft.EntityFrameworkCore;

namespace eShopSolution.WebApp.Models.Products
{
    public class ProductsModel: IProductsModel
    {
        private readonly eShopContext _context;

        public ProductsModel(eShopContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> getAllProducts()
        {
            return await _context.Product.Select(x => new Product
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                OriginalPrice = x.OriginalPrice,
                ViewCount = x.ViewCount,
                DateCreated = x.DateCreated,
                Status = x.Status
            }).ToListAsync();
        }
        public async Task<Product> loadProduct(int? id)
        {
            var product = await _context.Product.Where(x => x.Id == id).Select(x => new Product
            {
                Id = x.Id,
                Name = x.Name,
                OriginalPrice = x.OriginalPrice,
                ViewCount = x.ViewCount,
                DateCreated = x.DateCreated,
                Status = x.Status
            }).FirstOrDefaultAsync();
            if (product != null)
            {
                return product;
            }
            else return new Product();
        }
        public async Task createProduct(Product product)
        {
            _context.Product.Add(new eShopSolution.Database.Entities.Products
            {
                Name = product.Name,
                Price = product.Price,
                OriginalPrice = product.OriginalPrice,
                ViewCount = product.ViewCount,
                DateCreated = DateTime.Now,
                Status = product.Status
            });
            await _context.SaveChangesAsync();
        }
        public async Task updateProduct(Product product)
        {
            _context.Product.Update(new eShopSolution.Database.Entities.Products
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                OriginalPrice = product.OriginalPrice,
                ViewCount = product.ViewCount,
                DateCreated = product.DateCreated,
                Status = product.Status
            });
            await _context.SaveChangesAsync();
        }
        public async Task deleteProduct(int? id)
        {
            var products = await _context.Product.Where(x => x.Id == id).FirstOrDefaultAsync();
            _context.Product.Remove(products);
            await _context.SaveChangesAsync();
        }
    }
}
