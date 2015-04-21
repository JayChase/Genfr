using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Genfr.Repository
{
    public interface IQueryBuilder<T>: IQueryable<T>
    {        
        /// <summary>
        /// Asynchronously determines whether all the elements of a sequence satisfy a condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<bool> AllAsync(Expression<Func<T, bool>> predicate);
        
        /// <summary>
        /// Asynchronously determines whether all the elements of a sequence satisfy a condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>        
        Task<bool> AllAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously determines whether a sequence contains any elements.
        /// </summary>
        /// <returns></returns>
        Task<bool> AnyAsync();
        
        /// <summary>
        /// Asynchronously determines whether a sequence contains any elements.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> AnyAsync(CancellationToken cancellationToken);
        /// <summary>
        /// Asynchronously determines whether any element of a sequence satisfies a condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        
        /// <summary>
        /// Asynchronously determines whether any element of a sequence satisfies a condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable System.Decimal values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<decimal?> AverageAsync(Expression<Func<T, decimal?>> selector);
        
        /// <summary>
        /// Asynchronously computes the average of a sequence of System.Decimal values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<decimal> AverageAsync(Expression<Func<T, decimal>> selector);
        
        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable System.Double values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<double?> AverageAsync(Expression<Func<T, double?>> selector);
        
        /// <summary>
        /// Asynchronously computes the average of a sequence of System.Double values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<double> AverageAsync(Expression<Func<T, double>> selector);
        
        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable System.Single values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<float?> AverageAsync(Expression<Func<T, float?>> selector);
        
        /// <summary>
        /// Asynchronously computes the average of a sequence of System.Single values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<float> AverageAsync(Expression<Func<T, float>> selector);
        
        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable System.Int32 values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<double?> AverageAsync(Expression<Func<T, int?>> selector);
        
        /// <summary>
        /// Asynchronously computes the average of a sequence of System.Int32 values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<double> AverageAsync(Expression<Func<T, int>> selector);
        
        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable System.Int64 values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<double?> AverageAsync(Expression<Func<T, long?>> selector);
        
        /// <summary>
        /// Asynchronously computes the average of a sequence of System.Int64 values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<double> AverageAsync(Expression<Func<T, long>> selector);
        
        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable System.Decimal values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<decimal?> AverageAsync(Expression<Func<T, decimal?>> selector, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously computes the average of a sequence of System.Decimal values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<decimal> AverageAsync(Expression<Func<T, decimal>> selector, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable System.Double values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<double?> AverageAsync(Expression<Func<T, double?>> selector, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously computes the average of a sequence of System.Double values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<double> AverageAsync(Expression<Func<T, double>> selector, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable System.Single values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<float?> AverageAsync(Expression<Func<T, float?>> selector, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously computes the average of a sequence of System.Single values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<float> AverageAsync(Expression<Func<T, float>> selector, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable System.Int32 values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<double?> AverageAsync(Expression<Func<T, int?>> selector, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously computes the average of a sequence of System.Int32 values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<double> AverageAsync(Expression<Func<T, int>> selector, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable System.Int64 values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<double?> AverageAsync(Expression<Func<T, long?>> selector, CancellationToken cancellationToken);

        /// <summary>
        /// Asynchronously determines whether a sequence contains a specified element by using the default equality comparer.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Task<bool> ContainsAsync(T item);
        
        /// <summary>
        /// Asynchronously determines whether a sequence contains a specified element by using the default equality comparer.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> ContainsAsync(T item, CancellationToken cancellationToken);

        /// <summary>
        /// Asynchronously returns the number of elements in a sequence.
        /// </summary>
        /// <returns></returns>
        Task<int> CountAsync();
        
        /// <summary>
        /// Asynchronously returns the number of elements in a sequence.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<int> CountAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously returns the number of elements in a sequence that satisfy a condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Asynchronously returns the number of elements in a sequence that satisfy a condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<int> CountAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

        /// <summary>
        /// Asynchronously returns the first element of a sequence.
        /// </summary>
        /// <returns></returns>
        Task<T> FirstAsync();
        
        /// <summary>
        /// Asynchronously returns the first element of a sequence.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> FirstAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously returns the first element of a sequence that satisfies a specified condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> FirstAsync(Expression<Func<T, bool>> predicate);
        
        /// <summary>
        /// Asynchronously returns the first element of a sequence that satisfies a specified condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> FirstAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);
        /// <summary>
        /// Asynchronously returns the first element of a sequence, or a default value if the sequence contains no elements.
        /// </summary>
        /// <returns></returns>
        Task<T> FirstOrDefaultAsync();
        
        /// <summary>
        /// Asynchronously returns the first element of a sequence, or a default value if the sequence contains no elements.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> FirstOrDefaultAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously returns the first element of a sequence that satisfies a specified condition or a default value if no such element is found.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
     
        /// <summary>
        /// Asynchronously returns the first element of a sequence that satisfies a specified condition or a default value if no such element is found.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

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
        /// <returns></returns>
        Task ForEachAsync(Action<object> action);
 
        /// <summary>
        /// Asynchronously enumerates the query results and performs the specified action on each element.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task ForEachAsync(Action<T> action, CancellationToken cancellationToken);
   
        /// <summary>
        /// Asynchronously enumerates the query results and performs the specified action on each element.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task ForEachAsync(Action<object> action, CancellationToken cancellationToken);

        /// <summary>
        /// Specifies the related objects to include in the query results.
        /// </summary>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>        
        IQueryBuilder<T> Include<TProperty>(Expression<Func<T, TProperty>> path);
     
        /// <summary>
        /// Specifies the related objects to include in the query results.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        IQueryBuilder<T> Include(string path);

   
        /// <summary>        
        /// Asynchronously returns an System.Int64 that represents the total number of elements in a sequence.    
        /// </summary>    
        /// <returns></returns>
        Task<long> LongCountAsync();
        
        /// <summary>
        /// Asynchronously returns an System.Int64 that represents the total number of elements in a sequence
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<long> LongCountAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously returns an System.Int64 that represents the number of elements in a sequence that satisfy a condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<long> LongCountAsync(Expression<Func<T, bool>> predicate);
        
        /// <summary>
        /// Asynchronously returns an System.Int64 that represents the number of elements in a sequence that satisfy a condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<long> LongCountAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

        /// <summary>
        /// Asynchronously returns the maximum value of a sequence.
        /// </summary>
        /// <returns></returns>
        Task<T> MaxAsync();
        
        /// <summary>
        /// Asynchronously returns the maximum value of a sequence.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> MaxAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously invokes a projection function on each element of a sequence and returns the maximum resulting value.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<TResult> MaxAsync<TResult>(Expression<Func<T, TResult>> selector);
        
        /// <summary>
        /// Asynchronously invokes a projection function on each element of a sequence and returns the maximum resulting value.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<TResult> MaxAsync<TResult>(Expression<Func<T, TResult>> selector, CancellationToken cancellationToken);

        /// <summary>
        /// Asynchronously returns the minimum value of a sequence.
        /// </summary>
        /// <returns></returns>
        Task<T> MinAsync();
        
        /// <summary>
        /// Asynchronously returns the minimum value of a sequence.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> MinAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously invokes a projection function on each element of a sequence and returns the minimum resulting value.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<TResult> MinAsync<TResult>(Expression<Func<T, TResult>> selector);
        
        /// <summary>
        /// Asynchronously invokes a projection function on each element of a sequence and returns the minimum resulting value.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<TResult> MinAsync<TResult>(Expression<Func<T, TResult>> selector, CancellationToken cancellationToken);

        /// <summary>
        /// Projects each element of a sequence into a new form by incorporating the element's index.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="selector"></param>
        /// <returns></returns>
        IQueryBuilder<TResult> Select<TResult>(Expression<Func<T, TResult>> selector);

        /// <summary>
        /// Asynchronously returns the only element of a sequence, and throws an exception if there is not exactly one element in the sequence.
        /// </summary>
        /// <returns></returns>
        Task<T> SingleAsync();
       
        /// <summary>
        /// Asynchronously returns the only element of a sequence, and throws an exception if there is not exactly one element in the sequence.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> SingleAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously returns the only element of a sequence that satisfies a specified condition, and throws an exception if more than one such element exists.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> SingleAsync(Expression<Func<T, bool>> predicate);
        
        /// <summary>
        /// Asynchronously returns the only element of a sequence that satisfies a specified condition, and throws an exception if more than one such element exists.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> SingleAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

       /// <summary>
        /// Asynchronously returns the only element of a sequence, or a default value if the sequence is empty; this method throws an exception if there is more than one element in the sequence.
       /// </summary>
       /// <returns></returns>
        Task<T> SingleOrDefaultAsync();
        
        /// <summary>
        ///  Asynchronously returns the only element of a sequence, or a default value if the sequence is empty; this method throws an exception if there is more than one element in the sequence.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> SingleOrDefaultAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously returns the only element of a sequence that satisfies a specified condition or a default value if no such element exists; this method throws an exception if more than one element satisfies the condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);
      
        /// <summary>
        /// Asynchronously returns the only element of a sequence that satisfies a specified condition or a default value if no such element exists; this method throws an exception if more than one element satisfies the condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable System.Decimal values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<decimal?> SumAsync(Expression<Func<T, decimal?>> selector);
        
        /// <summary>
        /// Asynchronously computes the sum of the sequence of System.Decimal values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<decimal> SumAsync(Expression<Func<T, decimal>> selector);
        
        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable System.Double values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<double?> SumAsync(Expression<Func<T, double?>> selector);
        
        /// <summary>
        /// Asynchronously computes the sum of the sequence of System.Double values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<double> SumAsync(Expression<Func<T, double>> selector);
       
        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable System.Single values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<float?> SumAsync(Expression<Func<T, float?>> selector);

        /// <summary>
        /// Asynchronously computes the sum of the sequence of System.Single values that is obtained by invoking a projection function on each element of the input sequence
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<float> SumAsync(Expression<Func<T, float>> selector);
        
        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable System.Int32 values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<int?> SumAsync(Expression<Func<T, int?>> selector);
        

        /// <summary>
        /// Asynchronously computes the sum of the sequence of System.Int32 values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<int> SumAsync(Expression<Func<T, int>> selector);
        
        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable System.Int64 values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<long?> SumAsync(Expression<Func<T, long?>> selector);
       
        /// <summary>
        /// Asynchronously computes the sum of the sequence of System.Int64 values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task<long> SumAsync(Expression<Func<T, long>> selector);
        
        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable System.Decimal values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<decimal?> SumAsync(Expression<Func<T, decimal?>> selector, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously computes the sum of the sequence of System.Decimal values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<decimal> SumAsync(Expression<Func<T, decimal>> selector, CancellationToken cancellationToken);
      
        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable System.Double values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<double?> SumAsync(Expression<Func<T, double?>> selector, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously computes the sum of the sequence of System.Double values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<double> SumAsync(Expression<Func<T, double>> selector, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable System.Single values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<float?> SumAsync(Expression<Func<T, float?>> selector, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously computes the sum of the sequence of System.Single values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<float> SumAsync(Expression<Func<T, float>> selector, CancellationToken cancellationToken);
               
        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable System.Int32 values that is obtained by invoking a projection function on each element of the input sequence.       
        /// </summary>       
        /// <param name="selector"></param>       
        /// <param name="cancellationToken"></param>       
        /// <returns></returns>
        Task<int?> SumAsync(Expression<Func<T, int?>> selector, CancellationToken cancellationToken);
       
        /// <summary>
        /// Asynchronously computes the sum of the sequence of System.Int32 values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<int> SumAsync(Expression<Func<T, int>> selector, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable System.Int64 values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<long?> SumAsync(Expression<Func<T, long?>> selector, CancellationToken cancellationToken);
        
        /// <summary>
        /// Asynchronously computes the sum of the sequence of System.Int64 values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<long> SumAsync(Expression<Func<T, long>> selector, CancellationToken cancellationToken);

        /// <summary>
        /// Returns a specified number of contiguous elements from the start of a sequence.
        /// </summary>
        /// <param name="countAccessor"></param>
        /// <returns></returns>
        IQueryBuilder<T> Take(Expression<Func<int>> countAccessor);

        IQueryBuilder<T> Take(int count);

        /// <summary>
        /// Creates an array from an System.Linq.IQueryable<T> by enumerating it asynchronously.
        /// </summary>
        /// <returns></returns>
        Task<T[]> ToArrayAsync();
        
        /// <summary>
        /// Creates an array from an System.Linq.IQueryable<T> by enumerating it asynchronously.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<T[]> ToArrayAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Creates a System.Collections.Generic.Dictionary<TKey,TValue> from an System.Linq.IQueryable<T> by enumerating it asynchronously according to a specified key selector function.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        Task<Dictionary<TKey, T>> ToDictionaryAsync<TKey>(Func<T, TKey> keySelector);
        
        /// <summary>
        /// Creates a System.Collections.Generic.Dictionary<TKey,TValue> from an System.Linq.IQueryable<T> by enumerating it asynchronously according to a specified key selector function.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Dictionary<TKey, T>> ToDictionaryAsync<TKey>(Func<T, TKey> keySelector, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a System.Collections.Generic.Dictionary<TKey,TValue> from an System.Linq.IQueryable<T> by enumerating it asynchronously according to a specified key selector and an element selector function.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TElement"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="elementSelector"></param>
        /// <returns></returns>
        Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TKey, TElement>(Func<T, TKey> keySelector, Func<T, TElement> elementSelector);
        
        /// <summary>
        /// Creates a System.Collections.Generic.Dictionary<TKey,TValue> from an System.Linq.IQueryable<T> by enumerating it asynchronously according to a specified key selector function and a comparer.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        Task<Dictionary<TKey, T>> ToDictionaryAsync<TKey>(Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer);
        
        /// <summary>
        /// Creates a System.Collections.Generic.Dictionary<TKey,TValue> from an System.Linq.IQueryable<T> by enumerating it asynchronously according to a specified key selector and an element selector function.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TElement"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="elementSelector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TKey, TElement>(Func<T, TKey> keySelector, Func<T, TElement> elementSelector, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a System.Collections.Generic.Dictionary<TKey,TValue> from an System.Linq.IQueryable<T> by enumerating it asynchronously according to a specified key selector function, a comparer, and an element selector function.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TElement"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="elementSelector"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TKey, TElement>(Func<T, TKey> keySelector, Func<T, TElement> elementSelector, IEqualityComparer<TKey> comparer);
       
        /// <summary>
        /// Creates a System.Collections.Generic.Dictionary<TKey,TValue> from an System.Linq.IQueryable<T> by enumerating it asynchronously according to a specified key selector function and a comparer.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="comparer"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Dictionary<TKey, T>> ToDictionaryAsync<TKey>(Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken);
        
        /// <summary>
        ///   Creates a System.Collections.Generic.Dictionary<TKey,TValue> from an System.Linq.IQueryable<T> by enumerating it asynchronously according to a specified key selector function, a comparer, and an element selector function.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TElement"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="elementSelector"></param>
        /// <param name="comparer"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TKey, TElement>(Func<T, TKey> keySelector, Func<T, TElement> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken);

        /// <summary>
        /// Creates a System.Collections.Generic.List<T> from an System.Linq.IQueryable<T> by enumerating it asynchronously.
        /// </summary>
        /// <returns></returns>
        Task<List<T>> ToListAsync();        
        
        /// <summary>
        /// Creates a System.Collections.Generic.List<T> from an System.Linq.IQueryable<T> by enumerating it asynchronously.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<List<T>> ToListAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Sorts the elements of a sequence in ascending order according to a key.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        IOrderedQueryBuilder<T> OrderBy<TKey>(Expression<Func<T, TKey>> keySelector);

        /// <summary>
        /// Sorts the elements of a sequence in ascending order according to a key.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        IOrderedQueryBuilder<T> OrderBy<TKey>(string propertyName);
        
        /// <summary>
        /// Sorts the elements of a sequence in ascending order by using a specified comparer.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        IOrderedQueryBuilder<T> OrderBy<TKey>(Expression<Func<T, TKey>> keySelector, IComparer<TKey> comparer);
        
        /// <summary>
        /// Sorts the elements of a sequence in descending order according to a key.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        IOrderedQueryBuilder<T> OrderByDescending<TKey>(Expression<Func<T, TKey>> keySelector);

        /// <summary>
        /// Sorts the elements of a sequence in descending order according to a key.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        IOrderedQueryBuilder<T> OrderByDescending<TKey>(string propertyName);
        
        /// <summary>
        /// Sorts the elements of a sequence in descending order by using a specified comparer.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        IOrderedQueryBuilder<T> OrderByDescending<TKey>(Expression<Func<T, TKey>> keySelector, IComparer<TKey> comparer);

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IQueryBuilder<T> Where(Expression<Func<T, bool>> predicate);
        
        /// <summary>
        /// Filters a sequence of values based on a predicate. Each element's index is used in the logic of the predicate function.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IQueryBuilder<T> Where(Expression<Func<T, int, bool>> predicate);

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
