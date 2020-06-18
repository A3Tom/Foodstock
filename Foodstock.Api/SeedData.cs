using System;
using System.Collections.Generic;
using System.Linq;
using Foodstock.Data.Contexts;
using Foodstock.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Foodstock.Api
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var dbOptions = serviceProvider.GetRequiredService<DbContextOptions<FoodstockDbContext>>();

            using (var context = new FoodstockDbContext(dbOptions))
            {
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(BuildSeedCategories());

                    context.SaveChanges();
                }
            }
        }

        private static List<Category> BuildSeedCategories()
        {
            return new List<Category>()
            {
                new Category()
                {
                    Name = "Meat",
                    Active = true
                },
                new Category()
                {
                    Name = "Veggies",
                    Active = true
                },
                new Category()
                {
                    Name = "Fruit",
                    Active = true
                },
            };
        }
    }
}
