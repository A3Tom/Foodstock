using Foodstock.Domain.Enums;
using Foodstock.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Foodstock.Data.Contexts
{
    public class FoodstockDbContext : DbContext
    {
        public FoodstockDbContext(DbContextOptions options) : base(options)
        { 
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<TransactionLog> TransactionLogs { get; set; }
    } 
}
