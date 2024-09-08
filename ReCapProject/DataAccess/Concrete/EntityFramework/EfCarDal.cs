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
    public class EfCarDal : ICarDal
    {
        // Objects written in Using are directly cleaned by Garbage Collector when Using is finished.
        // IDisposable Pattern implementation of C#.
        public void Add(Car entity)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                var addedEntity = databaseContext.Entry(entity); // Find the reference.
                addedEntity.State = EntityState.Added; // Will be added object.
                databaseContext.SaveChanges(); // Save in DB.
            }
        }

        public void Delete(Car entity)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                var removedEntity = databaseContext.Entry(entity); // Find the reference.
                removedEntity.State = EntityState.Deleted; // Will be deleted object.
                databaseContext.SaveChanges(); // Delete from DB.
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                return databaseContext.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                return filter == null
                    ? databaseContext.Set<Car>().ToList()
                    : databaseContext.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
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
