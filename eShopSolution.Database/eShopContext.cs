using eShopSolution.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Database
{
    public class eShopContext: DbContext
    {
        public eShopContext(DbContextOptions<eShopContext> options): base(options)
        {

        }

        public DbSet<Products> Product { get; set; }
    }
}
