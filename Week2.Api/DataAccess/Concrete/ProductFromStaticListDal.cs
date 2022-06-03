using Week2.Api.DataAccess.Abstract;
using Week2.Api.Entities.Concrete;

namespace Week2.Api.DataAccess.Concrete;

public class ProductFromStaticListDal : EntityFromStaticListRepositoryBase<Product>
{
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
}