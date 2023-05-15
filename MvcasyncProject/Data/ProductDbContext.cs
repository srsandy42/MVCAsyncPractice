using Microsoft.EntityFrameworkCore;
using MvcasyncProject.Models;
using System.Collections.Generic;

namespace MvcasyncProject.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
