using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            // Objects written in Using are directly cleaned by Garbage Collector when Using is finished.
            // IDisposable Pattern implementation of C#.
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                var addedEntity = northwindContext.Entry(entity); // Find the reference.
                addedEntity.State = EntityState.Added; // Will be added object.
                northwindContext.SaveChanges(); // Save in DB.
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                var deletedEntity = northwindContext.Entry(entity); // Find the reference.
                deletedEntity.State = EntityState.Deleted; // Will be deleted object.
                northwindContext.SaveChanges(); // Delete from DB.
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                return northwindContext.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                return filter == null
                    ? northwindContext.Set<Product>().ToList()
                    : northwindContext.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                var updatedEntity = northwindContext.Entry(entity); // Find the reference.
                updatedEntity.State = EntityState.Modified; // Will be updated object.
                northwindContext.SaveChanges(); // Update into DB.
            }
        }
    }
}
