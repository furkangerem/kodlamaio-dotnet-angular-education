using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // Generic Constrait where T : class, IEntity, new()
    // T must be a reference type, it must also be an IEntity or a class that implements it,
    // but it must not be an Interface, that is, it must be a newable object.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        // Filter = null means, that's optional.
        // If there is any filter it will biring filtered data.If there isn't it will bring whole data.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
