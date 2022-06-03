using Week2.Api.DataAccess.Abstract;
using Week2.Api.Entities.Concrete;

namespace Week2.Api.DataAccess.Concrete;

public class ProductFromStaticListDal : EntityFromStaticListRepositoryBase<Product>, IProductDal
{
    private bool IsInitialized = false;
    private void Initialize()
    {
        _listOfEntities = new List<Product>();
        _listOfEntities.Add(
            new Product()
            {
                Id = 1,
                CategoryId = 1,
                ProductName = "Soap",
                UnitPrice = 5,
                StockAmount = 10
            });
        _listOfEntities.Add(
            new Product()
            {
                Id = 2,
                CategoryId = 1,
                ProductName = "Detergent",
                UnitPrice = 30,
                StockAmount = 30
            });
        _listOfEntities.Add(
            new Product()
            {
                Id = 3,
                CategoryId = 2,
                ProductName = "Milk",
                UnitPrice = 20,
                StockAmount = 8
            });
        IsInitialized = true;
    }

    public override List<Product> GetAll()
    {
        if (!IsInitialized)
        {
            Initialize();
        }
        return base.GetAll();
    }

    public override void Update(Product givenProduct)
    {
        var updatedProduct = _listOfEntities.FirstOrDefault(p => p.Id == givenProduct.Id);

        updatedProduct.CategoryId = givenProduct.CategoryId;
        updatedProduct.ProductName = givenProduct.ProductName;
        updatedProduct.UnitPrice = givenProduct.UnitPrice;
        updatedProduct.StockAmount = givenProduct.StockAmount;
    }

    public override void Delete(Product givenProduct)
    {
        int deletedProductIndex = _listOfEntities.FindIndex(p => p.Id == givenProduct.Id);

        _listOfEntities.RemoveAt(deletedProductIndex);
    }

    public Product GetById(int id)
    {
        return _listOfEntities.SingleOrDefault(p => p.Id == id);
    }
}