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
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                var addedEntity = databaseContext.Entry(entity); // Find the reference.
                addedEntity.State = EntityState.Added; // Will be added object.
                databaseContext.SaveChanges(); // Save in DB.
            }
        }

        public void Delete(Color entity)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                var removedEntity = databaseContext.Entry(entity); // Find the reference.
                removedEntity.State = EntityState.Deleted; // Will be deleted object.
                databaseContext.SaveChanges(); // Delete from DB.
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                return databaseContext.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                return filter == null
                    ? databaseContext.Set<Color>().ToList()
                    : databaseContext.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
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
