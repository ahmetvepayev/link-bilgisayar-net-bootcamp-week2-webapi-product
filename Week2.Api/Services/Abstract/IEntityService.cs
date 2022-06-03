using Week2.Api.Entities.Abstract;

namespace Week2.Api.Services.Abstract;

public interface IEntityService
{
    List<IEntity> GetAll();
    bool Add(IEntity entity);
    bool Update(IEntity entity);
    bool Delete(IEntity entity);
}