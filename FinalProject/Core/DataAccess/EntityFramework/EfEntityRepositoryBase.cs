using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            // Objects written in Using are directly cleaned by Garbage Collector when Using is finished.
            // IDisposable Pattern implementation of C#.
            using (TContext tContext = new TContext())
            {
                var addedEntity = tContext.Entry(entity); // Find the reference.
                addedEntity.State = EntityState.Added; // Will be added object.
                tContext.SaveChanges(); // Save in DB.
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext tContext = new TContext())
            {
                var deletedEntity = tContext.Entry(entity); // Find the reference.
                deletedEntity.State = EntityState.Deleted; // Will be deleted object.
                tContext.SaveChanges(); // Delete from DB.
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext tContext = new TContext())
            {
                return tContext.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext tContext = new TContext())
            {
                return filter == null
                    ? tContext.Set<TEntity>().ToList()
                    : tContext.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext tContext = new TContext())
            {
                var updatedEntity = tContext.Entry(entity); // Find the reference.
                updatedEntity.State = EntityState.Modified; // Will be updated object.
                tContext.SaveChanges(); // Update into DB.
            }
        }
    }
}
