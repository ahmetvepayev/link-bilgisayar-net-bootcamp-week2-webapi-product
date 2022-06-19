using Microsoft.EntityFrameworkCore;
using Week2.Api.Entities.Abstract;
using Week2.Api.DataAccess.Concrete;

namespace Week2.Api.DataAccess.Abstract;

public abstract class EntityEfCoreInMemoryRepositoryBase<TEntity> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
{
    protected ApiDbContext _context;

    public virtual List<TEntity> GetAll()
    {
        return _context.Set<TEntity>().ToList();
    }

    public virtual void Add(TEntity entity)
    {
        var addedEntity = _context.Entry(entity);
        addedEntity.State = EntityState.Added;
        _context.SaveChanges();
    }

    public virtual void Update(TEntity entity)
    {
        var updatedEntity = _context.Entry(entity);
        updatedEntity.State = EntityState.Modified;
        _context.SaveChanges();
    }

    public virtual void Delete(TEntity entity)
    {
        var deletedEntity = _context.Entry(entity);
        deletedEntity.State = EntityState.Deleted;
        _context.SaveChanges();
    }
}