using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericFluentRepository.Repository
{
    public interface IQueryBuilder<T>
    {
        IQueryBuilder<T> Where(Expression<Func<T, bool>> predicate);
        IQueryBuilder<T> Include(Expression<Func<T, object>> path);
        IQueryBuilder<T> OrderBy(Expression<Func<T, object>> path);
        IQueryBuilder<T> OrderByDescending(Expression<Func<T, object>> path);
        IQueryBuilder<T> Page(int page, int pageSize);
        
        Task<bool> AllAsync(Expression<Func<T, bool>> predicate);

        T FirstOrDefault();
        Task<T> FirstOrDefaultAsync();

        List<T> ToList();
        Task<List<T>> ToListAsync();

        int Count();
        Task<int> CountAsync();
    }
}
