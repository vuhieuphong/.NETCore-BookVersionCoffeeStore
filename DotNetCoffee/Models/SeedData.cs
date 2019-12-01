using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;

namespace DotNetCoffee.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IServiceProvider services)
        {
            ApplicationDbContext context = services.GetRequiredService<ApplicationDbContext>();            
            //context.Database.Migrate(); 
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Americano",
                        Description = "Coffee 1",
                        Category = "Coffee",
                        Price = 5
                    },
                    new Product
                    {
                        Name = "Latte",
                        Description = "Coffee 2",
                        Category = "Coffee",
                        Price = 6
                    },
                    new Product
                    {
                        Name = "Cappuchino",
                        Description = "Coffee 3",
                        Category = "Coffee",
                        Price = 7
                    },
                    new Product
                    {
                        Name = "Black Tea",
                        Description = "Tea 1",
                        Category = "Tea",
                        Price = 5.5m
                    },
                    new Product
                    {
                        Name = "Green Tea",
                        Description = "Tea 2",
                        Category = "Tea",
                        Price = 6.5m
                    },
                    new Product
                    {
                        Name = "Oolong Tea",
                        Description = "Tea 3",
                        Category = "Tea",
                        Price = 7.5m
                    },
                    new Product
                    {
                        Name = "Banana Smoothies",
                        Description = "Smoothies 1",
                        Category = "Smoothies",
                        Price = 5.75m
                    },
                    new Product
                    {
                        Name = "Mango Smoothies",
                        Description = "Smoothies 2",
                        Category = "Smoothies",
                        Price = 6.75m
                    },
                    new Product
                    {
                        Name = "Strawberry Smoothies",
                        Description = "Smoothies 3",
                        Category = "Smoothies",
                        Price = 7.75m
                    });
                context.SaveChanges();
            }
        }
    }
}

