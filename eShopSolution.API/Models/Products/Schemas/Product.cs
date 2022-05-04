using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eShopSolution.WebApp.Models.Products.Schemas
{
    public class Product
    {
        public string Id { set; get; }
        public string Name { get; set; }
        public decimal Price { set; get; }
        public int ViewCount { set; get; }

        public Product()
        {
            Name = "";
            Price = 0;
            ViewCount = 0;
        }
    }
}
