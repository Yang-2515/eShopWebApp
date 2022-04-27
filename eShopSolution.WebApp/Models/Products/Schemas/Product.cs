using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eShopSolution.WebApp.Models.Products.Schemas
{
    public class Product
    {
        [Key]
        public int Id { set; get; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { set; get; }
        [Required]
        public decimal OriginalPrice { set; get; }
        [Required]
        [Range(1,int.MaxValue, ErrorMessage ="ViewCout > 0")]
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public string Status { get; set; }

        public Product()
        {
            Name = "";
            Price = 0;
            OriginalPrice = 0;
            ViewCount = 0;
            DateCreated = DateTime.Now;
            Status = "1";
        }
    }
}
