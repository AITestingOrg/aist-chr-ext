using System.Collections.Generic;

namespace AIST.DataAccess.Implementation
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void AddRange(IEnumerable<T> entity);
        T FindById(int id);
        IEnumerable<T> Get();
        void Update(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entity);
    }
}
