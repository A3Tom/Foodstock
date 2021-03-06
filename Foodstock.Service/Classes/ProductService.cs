﻿using System.Linq;
using System.Threading.Tasks;
using Foodstock.Data.Contexts;
using Foodstock.Domain.Models;
using Foodstock.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Foodstock.Service.Classes
{
    public class ProductService : IProductService
    {
        private readonly FoodstockDbContext _foodstockDbContext;

        public ProductService(FoodstockDbContext foodstockDbContext)
        {
            _foodstockDbContext = foodstockDbContext;
        }
        public async Task<Product> GetProductById(int productId)
        {
            return await _foodstockDbContext.Products
                .Where(x => x.Id == productId)
                .SingleAsync();
        }
    }
}
