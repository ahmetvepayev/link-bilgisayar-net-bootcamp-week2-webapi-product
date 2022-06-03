using Week2.Api.DataAccess.Abstract;
using Week2.Api.Entities.Concrete;
using Week2.Api.Services.Abstract;

namespace Week2.Api.Services.Concrete;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public List<Product> GetAll()
    {
        return _productDal.GetAll();
    }

    public bool Add(Product entity)
    {
        _productDal.Add(entity);

        return true;
    }

    public bool Update(Product entity)
    {
        _productDal.Update(entity);

        return true;
    }

    // public bool EntityExists(Product entity)
    // {
        
    // }

    public bool Delete(int id)
    {
        var deletedProduct = _productDal.GetById(id);
        _productDal.Delete(deletedProduct);

        return true;
    }
}