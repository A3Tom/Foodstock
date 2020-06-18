using System.Collections.Generic;
using System.Threading.Tasks;
using Foodstock.Data.Contexts;
using Foodstock.Domain.Models;
using Foodstock.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Foodstock.Service.Classes
{
    public class CategoryService : ICategoryService
    {
        private readonly FoodstockDbContext _foodstockDbContext;

        public CategoryService(FoodstockDbContext foodstockDbContext)
        {
            _foodstockDbContext = foodstockDbContext;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _foodstockDbContext.Categories.ToListAsync();
        }
    }
}
