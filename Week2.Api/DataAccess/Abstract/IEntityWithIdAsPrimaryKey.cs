using Week2.Api.Entities.Abstract;

namespace Week2.Api.DataAccess.Abstract;

public interface IEntityWithIdAsPrimaryKey<TEntity>
    where TEntity : class, IEntity, new()
{
    TEntity GetById(int id);
}