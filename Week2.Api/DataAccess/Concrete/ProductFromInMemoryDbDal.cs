using Microsoft.EntityFrameworkCore;
using Week2.Api.DataAccess.Abstract;
using Week2.Api.Entities.Abstract;
using Week2.Api.Entities.Concrete;

namespace Week2.Api.DataAccess.Concrete;

public class ProductFromInMemoryDbDal : EntityEfCoreInMemoryRepositoryBase<Product>, IProductDal
{
    public ProductFromInMemoryDbDal(ApiDbContext context)
    {
        _context = context;
    }

    public Product GetById(int id)
    {
        return _context.Set<Product>().FirstOrDefault(p => p.Id == id);
    }
}