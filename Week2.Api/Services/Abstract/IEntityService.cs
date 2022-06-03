using Week2.Api.Entities.Abstract;

namespace Week2.Api.Services.Abstract;

public interface IEntityService<TEntity>
    where TEntity : class, IEntity, new()
{
    List<TEntity> GetAll();
    bool Add(TEntity entity);
    bool Update(TEntity entity);
    bool Delete(int id);
    // bool EntityExists(TEntity entity);
}