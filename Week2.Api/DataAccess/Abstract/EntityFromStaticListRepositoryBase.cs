using Week2.Api.Entities.Abstract;

namespace Week2.Api.DataAccess.Abstract;

public abstract class EntityFromStaticListRepositoryBase<TEntity> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
{
    protected List<TEntity> _listOfEntities;

    public virtual List<TEntity> GetAll(){
        return _listOfEntities;
    }

    public virtual void Add(TEntity entity)
    {
        _listOfEntities.Add(entity);
    }

    public abstract void Update(TEntity entity);

    public abstract void Delete(TEntity entity);
}