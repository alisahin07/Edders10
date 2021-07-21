using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAcess
{
    public interface IRepository<T>
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Delete(T entity);

        void Update(T entity);

    }
}
