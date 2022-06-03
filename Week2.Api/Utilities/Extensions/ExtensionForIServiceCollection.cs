using Week2.Api.DataAccess.Abstract;
using Week2.Api.DataAccess.Concrete;
using Week2.Api.Services.Abstract;
using Week2.Api.Services.Concrete;

namespace Week2.Api.Utilities.Extensions;

public static class ExtensionForIServiceCollection
{
    public static void AddServiceAndRepository(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductManager>();
        services.AddScoped<IProductDal, ProductFromInMemoryDbDal>();
    }
}