using Microsoft.EntityFrameworkCore;
using Week2.Api.Entities.Concrete;

namespace Week2.Api.DataAccess.Concrete;

public class ApiDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
}