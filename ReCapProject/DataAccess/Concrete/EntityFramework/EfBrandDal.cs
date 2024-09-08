using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                var addedEntity = databaseContext.Entry(entity); // Find the reference.
                addedEntity.State = EntityState.Added; // Will be added object.
                databaseContext.SaveChanges(); // Save in DB.
            }
        }

        public void Delete(Brand entity)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                var removedEntity = databaseContext.Entry(entity); // Find the reference.
                removedEntity.State = EntityState.Deleted; // Will be deleted object.
                databaseContext.SaveChanges(); // Delete from DB.
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                return databaseContext.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                return filter == null
                    ? databaseContext.Set<Brand>().ToList()
                    : databaseContext.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand entity)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                var updatedEntity = databaseContext.Entry(entity); // Find the reference.
                updatedEntity.State = EntityState.Modified; // Will be updated object.
                databaseContext.SaveChanges(); // Update into DB.
            }
        }
    }
}
