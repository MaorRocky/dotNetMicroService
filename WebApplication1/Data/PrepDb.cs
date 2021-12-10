using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                Console.WriteLine("Seeding Platforms");
                context.Platforms.AddRange(
                    new Platform {Name = "PC", Publisher = "Microsoft", Cost = "Free"},
                    new Platform {Name = "Playstation", Publisher = "Sony", Cost = "Free"},
                    new Platform {Name = "Xbox", Publisher = "Microsoft", Cost = "Free"},
                    new Platform {Name = "Nintendo", Publisher = "Nintendo", Cost = "Free"}
                );
                context.SaveChanges();
                Console.WriteLine($"count is {context.Platforms.Count()}");
            }
            else
            {
                Console.WriteLine("We already have data in the database");
            }
        }
        
        
    }
}