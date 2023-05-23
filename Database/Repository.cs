using Microsoft.EntityFrameworkCore;

namespace Database;

public class Repository<TEntity> where TEntity : class
{
    private readonly VehicleTrafficContext context;
    private readonly DbSet<TEntity> dbSet;

    public Repository(VehicleTrafficContext bookDbContext)
    {
        context = bookDbContext;
        dbSet = bookDbContext.Set<TEntity>();
    }

    public List<TEntity> GetAll()
    {
        return dbSet.ToList();
    }

    public TEntity? GetById(int id)
    {
        return dbSet.Find(id);
    }

    public TEntity Create(TEntity entity)
    {
        var result = dbSet.Add(entity);
        context.SaveChanges();

        return result.Entity;
    }

    public void Update(TEntity entity)
    {
        dbSet.Update(entity);
        context.SaveChanges();
    }

    public void Remove(TEntity entity)
    {
        dbSet.Remove(entity);
        context.SaveChanges();
    }

    public void Remove(int id)
    {
        var entity = GetById(id);

        if (entity != null)
        {
            Remove(entity);
        }
    }
}