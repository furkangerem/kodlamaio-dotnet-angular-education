using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        // Objects written in Using are directly cleaned by Garbage Collector when Using is finished.
        // IDisposable Pattern implementation of C#.
        public void Add(TEntity entity)
        {
            using (TContext databaseContext = new TContext())
            {
                var addedEntity = databaseContext.Entry(entity); // Find the reference.
                addedEntity.State = EntityState.Added; // Will be added object.
                databaseContext.SaveChanges(); // Save in DB.
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext databaseContext = new TContext())
            {
                var removedEntity = databaseContext.Entry(entity); // Find the reference.
                removedEntity.State = EntityState.Deleted; // Will be deleted object.
                databaseContext.SaveChanges(); // Delete from DB.
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext databaseContext = new TContext())
            {
                return databaseContext.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext databaseContext = new TContext())
            {
                return filter == null
                    ? databaseContext.Set<TEntity>().ToList()
                    : databaseContext.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext databaseContext = new TContext())
            {
                var updatedEntity = databaseContext.Entry(entity); // Find the reference.
                updatedEntity.State = EntityState.Modified; // Will be updated object.
                databaseContext.SaveChanges(); // Update into DB.
            }
        }
    }
}
