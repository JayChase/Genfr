using Genfr.EntityFramework.ExceptionHandling;
using Genfr.Repository;
using Genfr.Repository.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Genfr.EntityFramework
{
    public class SqlQuery<T> : ISqlQuery<T>
    {  
        private IExceptionHandler exceptionHandler;
        private DbRawSqlQuery<T> Query { get; set; }

        public SqlQuery(DbRawSqlQuery<T> dbRawSqlQuery)
            : this(dbRawSqlQuery, new ExceptionHandler())
        {
        }

        public SqlQuery(DbRawSqlQuery<T> dbRawSqlQuery, IExceptionHandler exceptionHandler)            
        {
            if (dbRawSqlQuery == null)
            {
                throw new ArgumentNullException("dbRawSqlQuery");
            }

            this.Query = dbRawSqlQuery;
            this.exceptionHandler = exceptionHandler;
        }

        public Task<bool> AllAsync(Func<T, bool> predicate)
        {
            try
            {
                return this.Query.AllAsync(predicate);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<bool> AllAsync(Func<T, bool> predicate, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.AllAsync(predicate, cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<bool> AnyAsync()
        {
            try
            {
                return this.Query.AnyAsync();
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<bool> AnyAsync(CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.AnyAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<bool> AnyAsync(Func<T, bool> predicate)
        {
            try
            {
                return this.Query.AnyAsync(predicate);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<bool> AnyAsync(Func<T, bool> predicate, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.AnyAsync(predicate, cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<bool> ContainsAsync(T value)
        {
            try
            {
                return this.Query.ContainsAsync(value);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<bool> ContainsAsync(T value, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.ContainsAsync(value, cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<int> CountAsync()
        {
            try
            {
                return this.Query.CountAsync();
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<int> CountAsync(CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.CountAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<int> CountAsync(Func<T, bool> predicate)
        {
            try
            {
                return this.Query.CountAsync(predicate);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<int> CountAsync(Func<T, bool> predicate, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.CountAsync(predicate,cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> FirstAsync()
        {
            try
            {
                return this.Query.FirstAsync();
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> FirstAsync(CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.FirstAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> FirstAsync(Func<T, bool> predicate)
        {
            try
            {
                return this.Query.FirstAsync(predicate);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> FirstAsync(Func<T, bool> predicate, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.FirstAsync(predicate, cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> FirstOrDefaultAsync()
        {
            try
            {
                return this.Query.FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> FirstOrDefaultAsync(CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.FirstOrDefaultAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> FirstOrDefaultAsync(Func<T, bool> predicate)
        {
            try
            {
                return this.Query.FirstOrDefaultAsync(predicate);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> FirstOrDefaultAsync(Func<T, bool> predicate, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.FirstOrDefaultAsync(predicate,cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task ForEachAsync(Action<T> action)
        {
            try
            {
                return this.Query.ForEachAsync(action);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task ForEachAsync(Action<T> action, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.ForEachAsync(action,cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<long> LongCountAsync()
        {
            try
            {
                return this.Query.LongCountAsync();
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<long> LongCountAsync(CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.LongCountAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<long> LongCountAsync(Func<T, bool> predicate)
        {
            try
            {
                return this.Query.LongCountAsync(predicate);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<long> LongCountAsync(Func<T, bool> predicate, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.LongCountAsync(predicate, cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> MaxAsync()
        {
            try
            {
                return this.Query.MaxAsync();
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> MaxAsync(CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.MaxAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> MinAsync()
        {
            try
            {
                return this.Query.MinAsync();
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> MinAsync(CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.MinAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> SingleAsync()
        {
            try
            {
                return this.Query.SingleAsync();
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> SingleAsync(CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.SingleAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> SingleAsync(Func<T, bool> predicate)
        {
            try
            {
                return this.Query.SingleAsync(predicate);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> SingleAsync(Func<T, bool> predicate, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.SingleAsync(predicate,cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> SingleOrDefaultAsync()
        {
            try
            {
                return this.Query.SingleOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> SingleOrDefaultAsync(CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.SingleOrDefaultAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> SingleOrDefaultAsync(Func<T, bool> predicate)
        {
            try
            {
                return this.Query.SingleOrDefaultAsync(predicate);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T> SingleOrDefaultAsync(Func<T, bool> predicate, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.SingleOrDefaultAsync(predicate,cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T[]> ToArrayAsync()
        {
            try
            {
                return this.Query.ToArrayAsync();
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<T[]> ToArrayAsync(CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.ToArrayAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<Dictionary<TKey, T>> ToDictionaryAsync<TKey>(Func<T, TKey> keySelector)
        {
            try
            {
                return this.Query.ToDictionaryAsync(keySelector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<Dictionary<TKey, T>> ToDictionaryAsync<TKey>(Func<T, TKey> keySelector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.ToDictionaryAsync(keySelector,cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<Dictionary<TKey, TResult>> ToDictionaryAsync<TKey, TResult>(Func<T, TKey> keySelector, Func<T, TResult> elementSelector)
        {
            try
            {
                return this.Query.ToDictionaryAsync(keySelector,elementSelector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<Dictionary<TKey, T>> ToDictionaryAsync<TKey>(Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer)
        {
            try
            {
                return this.Query.ToDictionaryAsync(keySelector, comparer);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<Dictionary<TKey, TResult>> ToDictionaryAsync<TKey, TResult>(Func<T, TKey> keySelector, Func<T, TResult> elementSelector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.ToDictionaryAsync(keySelector, elementSelector,cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<Dictionary<TKey, TResult>> ToDictionaryAsync<TKey, TResult>(Func<T, TKey> keySelector, Func<T, TResult> elementSelector, IEqualityComparer<TKey> comparer)
        {
            try
            {
                return this.Query.ToDictionaryAsync(keySelector, elementSelector, comparer);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<Dictionary<TKey, T>> ToDictionaryAsync<TKey>(Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.ToDictionaryAsync(keySelector, comparer, cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<Dictionary<TKey, TResult>> ToDictionaryAsync<TKey, TResult>(Func<T, TKey> keySelector, Func<T, TResult> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.ToDictionaryAsync(keySelector, elementSelector, cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<List<T>> ToListAsync()
        {
            try
            {
                return this.Query.ToListAsync();
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<List<T>> ToListAsync(CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.ToListAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public List<T> ToList()
        {
            try
            {
                return this.Query.ToList();
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public T FirstOrDefault()
        {
            try
            {
                return this.Query.FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public T FirstOrDefault(Func<T, bool> predicate)
        {
            try
            {
                return this.Query.FirstOrDefault(predicate);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }
    }
}
