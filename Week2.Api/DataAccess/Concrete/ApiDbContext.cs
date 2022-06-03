using Microsoft.EntityFrameworkCore;
using Week2.Api.Entities.Concrete;

namespace Week2.Api.DataAccess.Concrete;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Product> Products { get; set; }
}