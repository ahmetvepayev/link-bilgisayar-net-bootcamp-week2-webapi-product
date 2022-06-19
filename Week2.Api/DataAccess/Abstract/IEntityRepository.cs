using Week2.Api.Entities.Abstract;

namespace Week2.Api.DataAccess.Abstract;

public interface IEntityRepository<T>
    where T : class, IEntity, new()
{
    List<T> GetAll();
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}