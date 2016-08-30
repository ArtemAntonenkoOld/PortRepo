using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Portfolio.DAL.Abstract.BaseRepositories
{
    public interface IBaseRepository<T> : IDisposable where T : class
    {

        void Insert(T item);
        void Update(T item);
        IEnumerable<T> Fetch();
        IEnumerable<T> FetchBy(Expression<Func<T, bool>> predicate);
        IEnumerable<T> PaggingFetch(int startIndex, int count);
        IEnumerable<T> PaggingFetchBy(Expression<Func<T, bool>> predicate, int startIndex, int count);

        int GetCount();
        T GetById(int id);

        void Remove(T item);
        void SaveContext();


    }
}
