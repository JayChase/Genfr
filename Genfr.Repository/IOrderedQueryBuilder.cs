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
        //
        // Summary:
        //     Performs a subsequent ordering of the elements in a sequence in ascending
        //     order according to a key.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IOrderedQueryable<T> that contains elements to sort.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by the function represented by keySelector.
        //
        // Returns:
        //     An System.Linq.IOrderedQueryable<T> whose elements are sorted according to
        //     a key.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or keySelector is null.
        IOrderedQueryBuilder<T> ThenBy<TKey>(Expression<Func<T,TKey>> keySelector);
        //
        // Summary:
        //     Performs a subsequent ordering of the elements in a sequence in ascending
        //     order by using a specified comparer.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IOrderedQueryable<T> that contains elements to sort.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   comparer:
        //     An System.Collections.Generic.IComparer<T> to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by the function represented by keySelector.
        //
        // Returns:
        //     An System.Linq.IOrderedQueryable<T> whose elements are sorted according to
        //     a key.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or keySelector or comparer is null.
        IOrderedQueryBuilder<T> ThenBy<TKey>(Expression<Func<T, TKey>> keySelector, IComparer<TKey> comparer);
        //
        // Summary:
        //     Performs a subsequent ordering of the elements in a sequence in descending
        //     order, according to a key.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IOrderedQueryable<T> that contains elements to sort.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by the function represented by keySelector.
        //
        // Returns:
        //     An System.Linq.IOrderedQueryable<T> whose elements are sorted in descending
        //     order according to a key.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or keySelector is null.
        IOrderedQueryBuilder<T> ThenByDescending<TKey>(Expression<Func<T, TKey>> keySelector);
        //
        // Summary:
        //     Performs a subsequent ordering of the elements in a sequence in descending
        //     order by using a specified comparer.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IOrderedQueryable<T> that contains elements to sort.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   comparer:
        //     An System.Collections.Generic.IComparer<T> to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key that is returned by the keySelector function.
        //
        // Returns:
        //     A collection whose elements are sorted in descending order according to a
        //     key.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or keySelector or comparer is null.
        IOrderedQueryBuilder<T> ThenByDescending<TKey>(Expression<Func<T, TKey>> keySelector, IComparer<TKey> comparer);

        //
        // Summary:
        //     Bypasses a specified number of elements in a sequence and then returns the
        //     remaining elements.
        //
        // Parameters:
        //   source:
        //     A sequence to return elements from.
        //
        //   countAccessor:
        //     An expression that evaluates to the number of elements to skip.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A sequence that contains elements that occur after the specified index in
        //     the input sequence.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        IQueryBuilder<T> Skip(Expression<Func<int>> countAccessor);

        IQueryBuilder<T> Skip(int count);

    }
}
