using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericFluentRepository.Repository
{
    public interface ISelectedQueryBuilder<T>
    {
        ISelectedQueryBuilder<T> Where(Expression<Func<T, bool>> predicate);        
        ISelectedQueryBuilder<T> OrderBy(Expression<Func<T, object>> path);
        ISelectedQueryBuilder<T> OrderByDescending(Expression<Func<T, object>> path);
        ISelectedQueryBuilder<T> Page(int page, int pageSize);
        ISelectedQueryBuilder<TResult> Select<TSource, TResult>(Expression<Func<TSource, TResult>> selector);
        
        
        Task<bool> AllAsync(Expression<Func<T, bool>> predicate);

        T FirstOrDefault();
        Task<T> FirstOrDefaultAsync();

        List<T> ToList();
        Task<List<T>> ToListAsync();

        int Count();
        Task<int> CountAsync();
    }
}
