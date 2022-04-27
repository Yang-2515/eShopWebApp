using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eShopSolution.Database.Entities
{
    [Table("Products")]
    public class Products
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
        public int ViewCount { set; get; }
        [Required]
        public DateTime DateCreated { set; get; }
        [Required]
        public string Status { get; set; }
    }
}
