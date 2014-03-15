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
    public interface IOrderedQueryBuilder<T> : IQueryBuilder<T>
    {

        /// <summary>
        ///    Performs a subsequent ordering of the elements in a sequence in ascending order according to a key.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        IOrderedQueryBuilder<T> ThenBy<TKey>(Expression<Func<T,TKey>> keySelector);
    
        /// <summary>
        /// Performs a subsequent ordering of the elements in a sequence in ascending order by using a specified comparer.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        IOrderedQueryBuilder<T> ThenBy<TKey>(Expression<Func<T, TKey>> keySelector, IComparer<TKey> comparer);
    
        /// <summary>
        /// Performs a subsequent ordering of the elements in a sequence in descending order, according to a key.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        IOrderedQueryBuilder<T> ThenByDescending<TKey>(Expression<Func<T, TKey>> keySelector);

        /// <summary>
        /// Performs a subsequent ordering of the elements in a sequence in descending order by using a specified comparer.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        IOrderedQueryBuilder<T> ThenByDescending<TKey>(Expression<Func<T, TKey>> keySelector, IComparer<TKey> comparer);

        /// <summary>
        /// Return a single page of T.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        IQueryBuilder<T> Page(int page, int pageSize);

        /// <summary>
        /// Bypasses a specified number of elements in a sequence and then returns the remaining elements.
        /// </summary>
        /// <param name="countAccessor"></param>
        /// <returns></returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        IQueryBuilder<T> Skip(Expression<Func<int>> countAccessor);

        /// <summary>
        /// Bypasses a specified number of elements in a sequence and then returns the remaining elements.
        /// </summary>
        /// <param name="countAccessor"></param>
        /// <returns></returns>
        IQueryBuilder<T> Skip(int count);

    }
}
