using Microsoft.EntityFrameworkCore;
using Week2.Api.DataAccess.Abstract;
using Week2.Api.Entities.Abstract;
using Week2.Api.Entities.Concrete;

namespace Week2.Api.DataAccess.Concrete;

public class ProductFromInMemoryDbDal : EntityEfCoreInMemoryRepositoryBase<Product>, IProductDal
{
    public ProductFromInMemoryDbDal(DbContext context)
    {
        _context = context;
    }
}