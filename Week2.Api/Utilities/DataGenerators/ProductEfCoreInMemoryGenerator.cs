using Microsoft.EntityFrameworkCore;
using Week2.Api.DataAccess.Concrete;
using Week2.Api.Entities.Concrete;

namespace Week2.Api.Utilities.DataGenerators;

public static class ProductEfCoreInMemoryGenerator
{
    public static void GenerateProducts(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            AddProducts(services);
        }
    }

    private static void AddProducts(IServiceProvider serviceProvider)
    {
        using (var context = new ApiDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApiDbContext>>()))
        {
            if (context.Products.Any())
            {
                return;
            }

            context.Products.AddRange(
                new Product()
                {
                    //Id = 1,
                    CategoryId = 1,
                    ProductName = "Soap",
                    UnitPrice = 5,
                    StockAmount = 10
                },
                new Product()
                {
                    //Id = 2,
                    CategoryId = 1,
                    ProductName = "Detergent",
                    UnitPrice = 30,
                    StockAmount = 30
                },
                new Product()
                {
                    //Id = 3,
                    CategoryId = 2,
                    ProductName = "Milk",
                    UnitPrice = 20,
                    StockAmount = 8
                }
            );

            context.SaveChanges();
        }
    }
}