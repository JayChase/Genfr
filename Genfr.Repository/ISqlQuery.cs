using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Genfr.Repository
{
    public interface ISqlQuery<T>
    {
        /// <summary>
        /// Asynchronously determines whether all the elements of the query satisfy a condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<bool> AllAsync(Func<T, bool> predicate);
     
        /// <summary>
        /// Asynchronously determines whether all the elements of the query satisfy a condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> AllAsync(Func<T, bool> predicate, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously determines whether the query contains any elements.
        /// </summary>
        /// <returns></returns>
        Task<bool> AnyAsync();

        /// <summary>
        /// Asynchronously determines whether the query contains any elements.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> AnyAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Asynchronously determines whether the query contains any elements.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<bool> AnyAsync(Func<T, bool> predicate);
        
        /// <summary>
        /// Asynchronously determines whether any element of the query satisfies a condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> AnyAsync(Func<T, bool> predicate, CancellationToken cancellationToken);

        /// <summary>
        /// Asynchronously determines whether the query contains a specified element by using the default equality comparer.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        Task<bool> ContainsAsync(T value);
        
        /// <summary>
        /// Asynchronously determines whether the query contains a specified element by using the default equality comparer.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> ContainsAsync(T value, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously returns the number of elements in the query.
        /// </summary>
        /// <returns></returns>
        Task<int> CountAsync();
        
        /// <summary>
        /// Asynchronously returns the number of elements in the query.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<int> CountAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously returns the number of elements in the query that satisfy a condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<int> CountAsync(Func<T, bool> predicate);
        
        /// <summary>
        /// Asynchronously returns the number of elements in the query that satisfy a condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<int> CountAsync(Func<T, bool> predicate, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously returns the first element of the query.
        /// </summary>
        /// <returns></returns>
        Task<T> FirstAsync();
        
        /// <summary>
        /// Asynchronously returns the first element of the query.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> FirstAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously returns the first element of the query that satisfies a specified condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> FirstAsync(Func<T, bool> predicate);
        
        /// <summary>
        /// Asynchronously returns the first element of the query that satisfies a specified condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> FirstAsync(Func<T, bool> predicate, CancellationToken cancellationToken);

        /// <summary>
        /// Asynchronously returns the first element of the query, or a default value if the the query result contains no elements.
        /// </summary>
        /// <returns></returns>
        Task<T> FirstOrDefaultAsync();
   
        /// <summary>
        /// Asynchronously returns the first element of the query, or a default value if the the query result contains no elements.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> FirstOrDefaultAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously returns the first element of the query that satisfies a specified condition or a default value if no such element is found.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> FirstOrDefaultAsync(Func<T, bool> predicate);
        
        /// <summary>
        /// Asynchronously returns the first element of the query that satisfies a specified condition or a default value if no such element is found.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> FirstOrDefaultAsync(Func<T, bool> predicate, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously enumerates the query results and performs the specified action on each element.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Task ForEachAsync(Action<T> action);
        
        
        /// <summary>
        /// Asynchronously enumerates the query results and performs the specified action on each element.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task ForEachAsync(Action<T> action, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously returns an System.Int64 that represents the total number of elements in the query.
        /// </summary>
        /// <returns></returns>
        Task<long> LongCountAsync();
        
        /// <summary>
        /// Asynchronously returns an System.Int64 that represents the total number of elements in the query.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<long> LongCountAsync(CancellationToken cancellationToken);
     
        /// <summary>
        ///  Asynchronously returns an System.Int64 that represents the number of elements in the query that satisfy a condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<long> LongCountAsync(Func<T, bool> predicate);
        
        /// <summary>
        /// Asynchronously returns an System.Int64 that represents the number of elements in the query that satisfy a condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<long> LongCountAsync(Func<T, bool> predicate, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously returns the maximum value of the query.
        /// </summary>
        /// <returns></returns>
        Task<T> MaxAsync();
        
        /// <summary>
        /// Asynchronously returns the maximum value of the query.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> MaxAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously returns the minimum value of the query.
        /// </summary>
        /// <returns></returns>
        Task<T> MinAsync();
        
        /// <summary>
        /// Asynchronously returns the minimum value of the query.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> MinAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously returns the only element of the query, and throws an exception if there is not exactly one element in the sequence.
        /// </summary>
        /// <returns></returns>
        Task<T> SingleAsync();
        
        /// <summary>
        /// Asynchronously returns the only element of the query, and throws an exception if there is not exactly one element in the sequence.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> SingleAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously returns the only element of the query that satisfies a specified condition, and throws an exception if more than one such element exists.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> SingleAsync(Func<T, bool> predicate);
        
        /// <summary>
        /// Asynchronously returns the only element of the query that satisfies a specified condition, and throws an exception if more than one such element exists.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> SingleAsync(Func<T, bool> predicate, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously returns the only element of a sequence, or a default value if the sequence is empty; this method throws an exception if there is more than one element in the sequence.
        /// </summary>
        /// <returns></returns>
        Task<T> SingleOrDefaultAsync();
        
        /// <summary>
        /// Asynchronously returns the only element of a sequence, or a default value if the sequence is empty; this method throws an exception if there is more than one element in the sequence.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> SingleOrDefaultAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously returns the only element of the query that satisfies a specified condition or a default value if no such element exists; this method throws an exception if more than one element satisfies the condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> SingleOrDefaultAsync(Func<T, bool> predicate);
        
        /// <summary>
        /// Asynchronously returns the only element of the query that satisfies a specified condition or a default value if no such element exists; this method throws an exception if more than one element satisfies the condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> SingleOrDefaultAsync(Func<T, bool> predicate, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates an array from the query by enumerating it asynchronously.
        /// </summary>
        /// <returns></returns>
        Task<T[]> ToArrayAsync();
        
        /// <summary>
        /// Creates an array from the query by enumerating it asynchronously.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T[]> ToArrayAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a System.Collections.Generic.Dictionary<TKey,TValue> from the query by enumerating it asynchronously according to a specified key selector function.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        Task<Dictionary<TKey, T>> ToDictionaryAsync<TKey>(Func<T, TKey> keySelector);
        
        /// <summary>
        /// Creates a System.Collections.Generic.Dictionary<TKey,TValue> from the query by enumerating it asynchronously according to a specified key selector function.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Dictionary<TKey, T>> ToDictionaryAsync<TKey>(Func<T, TKey> keySelector, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a System.Collections.Generic.Dictionary<TKey,TValue> from the query by enumerating it asynchronously according to a specified key selector and an element selector function.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="elementSelector"></param>
        /// <returns></returns>
        Task<Dictionary<TKey, TResult>> ToDictionaryAsync<TKey, TResult>(Func<T, TKey> keySelector, Func<T, TResult> elementSelector);
        
        /// <summary>
        /// Creates a System.Collections.Generic.Dictionary<TKey,TValue> from the query by enumerating it asynchronously according to a specified key selector function and a comparer.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        Task<Dictionary<TKey, T>> ToDictionaryAsync<TKey>(Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer);
        
        /// <summary>
        /// Creates a System.Collections.Generic.Dictionary<TKey,TValue> from the query by enumerating it asynchronously according to a specified key selector and an element selector function.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="elementSelector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Dictionary<TKey, TResult>> ToDictionaryAsync<TKey, TResult>(Func<T, TKey> keySelector, Func<T, TResult> elementSelector, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a System.Collections.Generic.Dictionary<TKey,TValue> from the query by enumerating it asynchronously according to a specified key selector function, a comparer, and an element selector function.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="elementSelector"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        Task<Dictionary<TKey, TResult>> ToDictionaryAsync<TKey, TResult>(Func<T, TKey> keySelector, Func<T, TResult> elementSelector, IEqualityComparer<TKey> comparer);
        
        /// <summary>
        /// Creates a System.Collections.Generic.Dictionary<TKey,TValue> from the query by enumerating it asynchronously according to a specified key selector function and a comparer.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="comparer"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Dictionary<TKey, T>> ToDictionaryAsync<TKey>(Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a System.Collections.Generic.Dictionary<TKey,TValue> from the query by enumerating it asynchronously according to a specified key selector function, a comparer, and an element selector function.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="elementSelector"></param>
        /// <param name="comparer"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Dictionary<TKey, TResult>> ToDictionaryAsync<TKey, TResult>(Func<T, TKey> keySelector, Func<T, TResult> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken);

        /// <summary>
        /// Creates a System.Collections.Generic.List<T> from the query by enumerating it asynchronously.
        /// </summary>
        /// <returns></returns>
        Task<List<T>> ToListAsync();
        
        /// <summary>
        /// Creates a System.Collections.Generic.List<T> from the query by enumerating it asynchronously.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<List<T>> ToListAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Creates a System.Collections.Generic.List<T> from an System.Collections.Generic.IEnumerable<T>.
        /// </summary>
        /// <returns></returns>
        List<T> ToList();

        /// <summary>
        /// Returns the first element of a sequence, or a default value if the sequence contains no elements.
        /// </summary>
        /// <returns></returns>
        T FirstOrDefault();

        /// <summary>
        /// Returns the first element of the sequence that satisfies a condition or a default value if no such element is found.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        T FirstOrDefault(Func<T, bool> predicate);
    }
}
