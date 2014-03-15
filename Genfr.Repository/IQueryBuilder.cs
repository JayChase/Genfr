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
    public interface IQueryBuilder<T>
    {        

        // Summary:
        //     Asynchronously determines whether all the elements of a sequence satisfy
        //     a condition.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> whose elements to test for a condition.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     true if every element of the source sequence passes the test in the specified
        //     predicate; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<bool> AllAsync(Expression<Func<T, bool>> predicate);
        //
        // Summary:
        //     Asynchronously determines whether all the elements of a sequence satisfy
        //     a condition.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> whose elements to test for a condition.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     true if every element of the source sequence passes the test in the specified
        //     predicate; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<bool> AllAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);
        
        //
        // Summary:
        //     Asynchronously determines whether a sequence contains any elements.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to check for being empty.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     true if the source sequence contains any elements; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<bool> AnyAsync();
        //
        // Summary:
        //     Asynchronously determines whether a sequence contains any elements.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to check for being empty.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     true if the source sequence contains any elements; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<bool> AnyAsync(CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously determines whether any element of a sequence satisfies a condition.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> whose elements to test for a condition.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     true if any elements in the source sequence pass the test in the specified
        //     predicate; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        //
        // Summary:
        //     Asynchronously determines whether any element of a sequence satisfies a condition.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> whose elements to test for a condition.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     true if any elements in the source sequence pass the test in the specified
        //     predicate; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Decimal
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<decimal?> AverageAsync(Expression<Func<T, decimal?>> selector);
        
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Decimal values
        //     that is obtained by invoking a projection function on each element of the
        //     input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<decimal> AverageAsync(Expression<Func<T, decimal>> selector);
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Double
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<double?> AverageAsync(Expression<Func<T, double?>> selector);
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Double values
        //     that is obtained by invoking a projection function on each element of the
        //     input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<double> AverageAsync(Expression<Func<T, double>> selector);
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Single
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<float?> AverageAsync(Expression<Func<T, float?>> selector);
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Single values
        //     that is obtained by invoking a projection function on each element of the
        //     input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<float> AverageAsync(Expression<Func<T, float>> selector);
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Int32
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<double?> AverageAsync(Expression<Func<T, int?>> selector);
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Int32 values
        //     that is obtained by invoking a projection function on each element of the
        //     input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<double> AverageAsync(Expression<Func<T, int>> selector);
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Int64
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<double?> AverageAsync(Expression<Func<T, long?>> selector);
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Int64 values
        //     that is obtained by invoking a projection function on each element of the
        //     input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<double> AverageAsync(Expression<Func<T, long>> selector);
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Decimal
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<decimal?> AverageAsync(Expression<Func<T, decimal?>> selector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Decimal values
        //     that is obtained by invoking a projection function on each element of the
        //     input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<decimal> AverageAsync(Expression<Func<T, decimal>> selector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Double
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<double?> AverageAsync(Expression<Func<T, double?>> selector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Double values
        //     that is obtained by invoking a projection function on each element of the
        //     input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<double> AverageAsync(Expression<Func<T, double>> selector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Single
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<float?> AverageAsync(Expression<Func<T, float?>> selector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Single values
        //     that is obtained by invoking a projection function on each element of the
        //     input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<float> AverageAsync(Expression<Func<T, float>> selector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Int32
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<double?> AverageAsync(Expression<Func<T, int?>> selector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Int32 values
        //     that is obtained by invoking a projection function on each element of the
        //     input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<double> AverageAsync(Expression<Func<T, int>> selector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Int64
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<double?> AverageAsync(Expression<Func<T, long?>> selector, CancellationToken cancellationToken);

        //
        // Summary:
        //     Asynchronously determines whether a sequence contains a specified element
        //     by using the default equality comparer.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to return the single element of.
        //
        //   item:
        //     The object to locate in the sequence.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     true if the input sequence contains the specified value; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<bool> ContainsAsync(T item);
        //
        // Summary:
        //     Asynchronously determines whether a sequence contains a specified element
        //     by using the default equality comparer.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to return the single element of.
        //
        //   item:
        //     The object to locate in the sequence.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     true if the input sequence contains the specified value; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<bool> ContainsAsync(T item, CancellationToken cancellationToken);

        //
        // Summary:
        //     Asynchronously returns the number of elements in a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> that contains the elements to be counted.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the number of elements in the input sequence.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source is larger than System.Int32.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<int> CountAsync();
        //
        // Summary:
        //     Asynchronously returns the number of elements in a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> that contains the elements to be counted.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the number of elements in the input sequence.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source is larger than System.Int32.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<int> CountAsync(CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously returns the number of elements in a sequence that satisfy
        //     a condition.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> that contains the elements to be counted.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the number of elements in the sequence that satisfy the condition in the
        //     predicate function.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source that satisfy the condition in the predicate
        //     function is larger than System.Int32.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);

        //
        // Summary:
        //     Asynchronously returns the number of elements in a sequence that satisfy
        //     a condition.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> that contains the elements to be counted.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the number of elements in the sequence that satisfy the condition in the
        //     predicate function.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source that satisfy the condition in the predicate
        //     function is larger than System.Int32.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<int> CountAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

        //
        // Summary:
        //     Asynchronously returns the first element of a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to return the first element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the first element in source.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null.
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider.
        //
        //   System.InvalidOperationException:
        //     The source sequence is empty.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<T> FirstAsync();
        //
        // Summary:
        //     Asynchronously returns the first element of a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to return the first element of.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the first element in source.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     The source sequence is empty.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<T> FirstAsync(CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously returns the first element of a sequence that satisfies a specified
        //     condition.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to return the first element of.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the first element in source that passes the test in predicate.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     No element satisfies the condition in predicate .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<T> FirstAsync(Expression<Func<T, bool>> predicate);
        //
        // Summary:
        //     Asynchronously returns the first element of a sequence that satisfies a specified
        //     condition.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to return the first element of.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the first element in source that passes the test in predicate.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     No element satisfies the condition in predicate .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<T> FirstAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

        //
        // Summary:
        //     Asynchronously returns the first element of a sequence, or a default value
        //     if the sequence contains no elements.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to return the first element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     default ( TSource ) if source is empty; otherwise, the first element in source.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<T> FirstOrDefaultAsync();
        //
        // Summary:
        //     Asynchronously returns the first element of a sequence, or a default value
        //     if the sequence contains no elements.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to return the first element of.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     default ( TSource ) if source is empty; otherwise, the first element in source.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<T> FirstOrDefaultAsync(CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously returns the first element of a sequence that satisfies a specified
        //     condition or a default value if no such element is found.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to return the first element of.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     default ( TSource ) if source is empty or if no element passes the test specified
        //     by predicate ; otherwise, the first element in source that passes the test
        //     specified by predicate.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        //
        // Summary:
        //     Asynchronously returns the first element of a sequence that satisfies a specified
        //     condition or a default value if no such element is found.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to return the first element of.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     default ( TSource ) if source is empty or if no element passes the test specified
        //     by predicate ; otherwise, the first element in source that passes the test
        //     specified by predicate.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     source has more than one element.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

        //
        // Summary:
        //     Asynchronously enumerates the query results and performs the specified action
        //     on each element.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to enumerate.
        //
        //   action:
        //     The action to perform on each element.
        //
        // Type parameters:
        //   T:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task ForEachAsync(Action<T> action);
        //
        // Summary:
        //     Asynchronously enumerates the query results and performs the specified action
        //     on each element.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable to enumerate.
        //
        //   action:
        //     The action to perform on each element.
        //
        // Returns:
        //     A task that represents the asynchronous operation.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task ForEachAsync(Action<object> action);
        //
        // Summary:
        //     Asynchronously enumerates the query results and performs the specified action
        //     on each element.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to enumerate.
        //
        //   action:
        //     The action to perform on each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   T:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task ForEachAsync(Action<T> action, CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously enumerates the query results and performs the specified action
        //     on each element.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable to enumerate.
        //
        //   action:
        //     The action to perform on each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Returns:
        //     A task that represents the asynchronous operation.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task ForEachAsync(Action<object> action, CancellationToken cancellationToken);

        //
        // Summary:
        //     Specifies the related objects to include in the query results.
        //
        // Parameters:
        //   source:
        //     The source IQueryable on which to call Include.
        //
        //   path:
        //     A lambda expression representing the path to include.
        //
        // Type parameters:
        //   T:
        //     The type of entity being queried.
        //
        //   TProperty:
        //     The type of navigation property being included.
        //
        // Returns:
        //     A new IQueryable<T> with the defined query path.
        //
        // Remarks:
        //     The path expression must be composed of simple property access expressions
        //     together with calls to Select for composing additional includes after including
        //     a collection proprty. Examples of possible include paths are: To include
        //     a single reference: query.Include(e => e.Level1Reference) To include a single
        //     collection: query.Include(e => e.Level1Collection) To include a reference
        //     and then a reference one level down: query.Include(e => e.Level1Reference.Level2Reference)
        //     To include a reference and then a collection one level down: query.Include(e
        //     => e.Level1Reference.Level2Collection) To include a collection and then a
        //     reference one level down: query.Include(e => e.Level1Collection.Select(l1
        //     => l1.Level2Reference)) To include a collection and then a collection one
        //     level down: query.Include(e => e.Level1Collection.Select(l1 => l1.Level2Collection))
        //     To include a collection and then a reference one level down: query.Include(e
        //     => e.Level1Collection.Select(l1 => l1.Level2Reference)) To include a collection
        //     and then a collection one level down: query.Include(e => e.Level1Collection.Select(l1
        //     => l1.Level2Collection)) To include a collection, a reference, and a reference
        //     two levels down: query.Include(e => e.Level1Collection.Select(l1 => l1.Level2Reference.Level3Reference))
        //     To include a collection, a collection, and a reference two levels down: query.Include(e
        //     => e.Level1Collection.Select(l1 => l1.Level2Collection.Select(l2 => l2.Level3Reference)))
        //     This extension method calls the Include(String) method of the source IQueryable
        //     object, if such a method exists.  If the source IQueryable does not have
        //     a matching method, then this method does nothing.  The Entity Framework ObjectQuery,
        //     ObjectSet, DbQuery, and DbSet types all have an appropriate Include method
        //     to call.  When you call the Include method, the query path is only valid
        //     on the returned instance of the IQueryable<T>. Other instances of IQueryable<T>
        //     and the object context itself are not affected. Because the Include method
        //     returns the query object, you can call this method multiple times on an IQueryable<T>
        //     to specify multiple paths for the query.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        IQueryBuilder<T> Include<TProperty>(Expression<Func<T, TProperty>> path);
        //
        // Summary:
        //     Specifies the related objects to include in the query results.
        //
        // Parameters:
        //   source:
        //     The source System.Linq.IQueryable<T> on which to call Include.
        //
        //   path:
        //     The dot-separated list of related objects to return in the query results.
        //
        // Type parameters:
        //   T:
        //     The type of entity being queried.
        //
        // Returns:
        //     A new System.Linq.IQueryable<T> with the defined query path.
        //
        // Remarks:
        //     This extension method calls the Include(String) method of the source System.Linq.IQueryable<T>
        //     object, if such a method exists. If the source System.Linq.IQueryable<T>
        //     does not have a matching method, then this method does nothing. The System.Data.Entity.Core.Objects.ObjectQuery<T>,
        //     System.Data.Entity.Core.Objects.ObjectSet<TEntity>, System.Data.Entity.Infrastructure.DbQuery<TResult>
        //     and System.Data.Entity.DbSet<TEntity> types all have an appropriate Include
        //     method to call.  Paths are all-inclusive. For example, if an include call
        //     indicates Include("Orders.OrderLines"), not only will OrderLines be included,
        //     but also Orders. When you call the Include method, the query path is only
        //     valid on the returned instance of the System.Linq.IQueryable<T>. Other instances
        //     of System.Linq.IQueryable<T> and the object context itself are not affected.
        //     Because the Include method returns the query object, you can call this method
        //     multiple times on an System.Linq.IQueryable<T> to specify multiple paths
        //     for the query.
        IQueryBuilder<T> Include(string path);

        //
        // Summary:
        //     Asynchronously returns an System.Int64 that represents the total number of
        //     elements in a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> that contains the elements to be counted.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the number of elements in the input sequence.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source is larger than System.Int64.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<long> LongCountAsync();
        //
        // Summary:
        //     Asynchronously returns an System.Int64 that represents the total number of
        //     elements in a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> that contains the elements to be counted.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the number of elements in the input sequence.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source is larger than System.Int64.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<long> LongCountAsync(CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously returns an System.Int64 that represents the number of elements
        //     in a sequence that satisfy a condition.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> that contains the elements to be counted.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the number of elements in the sequence that satisfy the condition in the
        //     predicate function.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source that satisfy the condition in the predicate
        //     function is larger than System.Int64.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<long> LongCountAsync(Expression<Func<T, bool>> predicate);
        //
        // Summary:
        //     Asynchronously returns an System.Int64 that represents the number of elements
        //     in a sequence that satisfy a condition.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> that contains the elements to be counted.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the number of elements in the sequence that satisfy the condition in the
        //     predicate function.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source that satisfy the condition in the predicate
        //     function is larger than System.Int64.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<long> LongCountAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

        //
        // Summary:
        //     Asynchronously returns the maximum value of a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> that contains the elements to determine the
        //     maximum of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the maximum value in the sequence.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<T> MaxAsync();
        //
        // Summary:
        //     Asynchronously returns the maximum value of a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> that contains the elements to determine the
        //     maximum of.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the maximum value in the sequence.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<T> MaxAsync(CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously invokes a projection function on each element of a sequence
        //     and returns the maximum resulting value.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> that contains the elements to determine the
        //     maximum of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TResult:
        //     The type of the value returned by the function represented by selector .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the maximum value in the sequence.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<TResult> MaxAsync<TResult>(Expression<Func<T, TResult>> selector);
        //
        // Summary:
        //     Asynchronously invokes a projection function on each element of a sequence
        //     and returns the maximum resulting value.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> that contains the elements to determine the
        //     maximum of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TResult:
        //     The type of the value returned by the function represented by selector .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the maximum value in the sequence.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<TResult> MaxAsync<TResult>(Expression<Func<T, TResult>> selector, CancellationToken cancellationToken);

        //
        // Summary:
        //     Asynchronously returns the minimum value of a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> that contains the elements to determine the
        //     minimum of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the minimum value in the sequence.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<T> MinAsync();
        //
        // Summary:
        //     Asynchronously returns the minimum value of a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> that contains the elements to determine the
        //     minimum of.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the minimum value in the sequence.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<T> MinAsync(CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously invokes a projection function on each element of a sequence
        //     and returns the minimum resulting value.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> that contains the elements to determine the
        //     minimum of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TResult:
        //     The type of the value returned by the function represented by selector .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the minimum value in the sequence.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<TResult> MinAsync<TResult>(Expression<Func<T, TResult>> selector);
        //
        // Summary:
        //     Asynchronously invokes a projection function on each element of a sequence
        //     and returns the minimum resulting value.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> that contains the elements to determine the
        //     minimum of.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TResult:
        //     The type of the value returned by the function represented by selector .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the minimum value in the sequence.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<TResult> MinAsync<TResult>(Expression<Func<T, TResult>> selector, CancellationToken cancellationToken);

        //
        // Summary:
        //     Projects each element of a sequence into a new form by incorporating the
        //     element's index.
        //
        // Parameters:
        //   source:
        //     A sequence of values to project.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TResult:
        //     The type of the value returned by the function represented by selector.
        //
        // Returns:
        //     An System.Linq.IQueryable<T> whose elements are the result of invoking a
        //     projection function on each element of source.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null.
        IQueryBuilder<TResult> Select<TResult>(Expression<Func<T, TResult>> selector);

        //
        // Summary:
        //     Asynchronously returns the only element of a sequence, and throws an exception
        //     if there is not exactly one element in the sequence.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to return the single element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the single element of the input sequence.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     The source sequence is empty.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<T> SingleAsync();
        //
        // Summary:
        //     Asynchronously returns the only element of a sequence, and throws an exception
        //     if there is not exactly one element in the sequence.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to return the single element of.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the single element of the input sequence.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     source has more than one element.
        //
        //   System.InvalidOperationException:
        //     The source sequence is empty.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<T> SingleAsync(CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously returns the only element of a sequence that satisfies a specified
        //     condition, and throws an exception if more than one such element exists.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to return the the single element of.
        //
        //   predicate:
        //     A function to test an element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the single element of the input sequence that satisfies the condition in
        //     predicate.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     No element satisfies the condition in predicate .
        //
        //   System.InvalidOperationException:
        //     More than one element satisfies the condition in predicate .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<T> SingleAsync(Expression<Func<T, bool>> predicate);
        //
        // Summary:
        //     Asynchronously returns the only element of a sequence that satisfies a specified
        //     condition, and throws an exception if more than one such element exists.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to return the single element of.
        //
        //   predicate:
        //     A function to test an element for a condition.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the single element of the input sequence that satisfies the condition in
        //     predicate.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     No element satisfies the condition in predicate .
        //
        //   System.InvalidOperationException:
        //     More than one element satisfies the condition in predicate .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<T> SingleAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

        //
        // Summary:
        //     Asynchronously returns the only element of a sequence, or a default value
        //     if the sequence is empty; this method throws an exception if there is more
        //     than one element in the sequence.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to return the single element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the single element of the input sequence, or default (TSource) if the sequence
        //     contains no elements.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     source has more than one element.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<T> SingleOrDefaultAsync();
        //
        // Summary:
        //     Asynchronously returns the only element of a sequence, or a default value
        //     if the sequence is empty; this method throws an exception if there is more
        //     than one element in the sequence.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to return the single element of.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the single element of the input sequence, or default (TSource) if the sequence
        //     contains no elements.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.InvalidOperationException:
        //     source has more than one element.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        Task<T> SingleOrDefaultAsync(CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously returns the only element of a sequence that satisfies a specified
        //     condition or a default value if no such element exists; this method throws
        //     an exception if more than one element satisfies the condition.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to return the single element of.
        //
        //   predicate:
        //     A function to test an element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the single element of the input sequence that satisfies the condition in
        //     predicate, or default ( TSource ) if no such element is found.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);
        //
        // Summary:
        //     Asynchronously returns the only element of a sequence that satisfies a specified
        //     condition or a default value if no such element exists; this method throws
        //     an exception if more than one element satisfies the condition.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to return the single element of.
        //
        //   predicate:
        //     A function to test an element for a condition.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the single element of the input sequence that satisfies the condition in
        //     predicate, or default ( TSource ) if no such element is found.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);
        
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of nullable System.Decimal
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source is larger than System.Decimal.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<decimal?> SumAsync(Expression<Func<T, decimal?>> selector);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of System.Decimal values
        //     that is obtained by invoking a projection function on each element of the
        //     input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source is larger than System.Decimal.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<decimal> SumAsync(Expression<Func<T, decimal>> selector);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of nullable System.Double
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<double?> SumAsync(Expression<Func<T, double?>> selector);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of System.Double values that
        //     is obtained by invoking a projection function on each element of the input
        //     sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<double> SumAsync(Expression<Func<T, double>> selector);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of nullable System.Single
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<float?> SumAsync(Expression<Func<T, float?>> selector);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of System.Single values that
        //     is obtained by invoking a projection function on each element of the input
        //     sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<float> SumAsync(Expression<Func<T, float>> selector);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of nullable System.Int32
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source is larger than System.Int32.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<int?> SumAsync(Expression<Func<T, int?>> selector);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of System.Int32 values that
        //     is obtained by invoking a projection function on each element of the input
        //     sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source is larger than System.Int32.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<int> SumAsync(Expression<Func<T, int>> selector);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of nullable System.Int64
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source is larger than System.Int64.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<long?> SumAsync(Expression<Func<T, long?>> selector);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of System.Int64 values that
        //     is obtained by invoking a projection function on each element of the input
        //     sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source is larger than System.Int64.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<long> SumAsync(Expression<Func<T, long>> selector);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of nullable System.Decimal
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source is larger than System.Decimal.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<decimal?> SumAsync(Expression<Func<T, decimal?>> selector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of System.Decimal values
        //     that is obtained by invoking a projection function on each element of the
        //     input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source is larger than System.Decimal.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<decimal> SumAsync(Expression<Func<T, decimal>> selector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of nullable System.Double
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<double?> SumAsync(Expression<Func<T, double?>> selector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of System.Double values that
        //     is obtained by invoking a projection function on each element of the input
        //     sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<double> SumAsync(Expression<Func<T, double>> selector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of nullable System.Single
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<float?> SumAsync(Expression<Func<T, float?>> selector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of System.Single values that
        //     is obtained by invoking a projection function on each element of the input
        //     sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<float> SumAsync(Expression<Func<T, float>> selector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of nullable System.Int32
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source is larger than System.Int32.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<int?> SumAsync(Expression<Func<T, int?>> selector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of System.Int32 values that
        //     is obtained by invoking a projection function on each element of the input
        //     sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source is larger than System.Int32.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<int> SumAsync(Expression<Func<T, int>> selector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of nullable System.Int64
        //     values that is obtained by invoking a projection function on each element
        //     of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source is larger than System.Int64.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<long?> SumAsync(Expression<Func<T, long?>> selector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Asynchronously computes the sum of the sequence of System.Int64 values that
        //     is obtained by invoking a projection function on each element of the input
        //     sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values of type TSource .
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the projected values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null .
        //
        //   System.InvalidOperationException:
        //     source doesn't implement System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
        //     .
        //
        //   System.OverflowException:
        //     The number of elements in source is larger than System.Int64.MaxValue .
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        Task<long> SumAsync(Expression<Func<T, long>> selector, CancellationToken cancellationToken);

        //
        // Summary:
        //     Returns a specified number of contiguous elements from the start of a sequence.
        //
        // Parameters:
        //   source:
        //     The sequence to return elements from.
        //
        //   countAccessor:
        //     An expression that evaluates to the number of elements to return.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A sequence that contains the specified number of elements from the start
        //     of the input sequence.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        IQueryBuilder<T> Take(Expression<Func<int>> countAccessor);

        IQueryBuilder<T> Take(int count);

        //
        // Summary:
        //     Creates an array from an System.Linq.IQueryable<T> by enumerating it asynchronously.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to create an array from.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     an array that contains elements from the input sequence.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<T[]> ToArrayAsync();
        //
        // Summary:
        //     Creates an array from an System.Linq.IQueryable<T> by enumerating it asynchronously.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to create an array from.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     an array that contains elements from the input sequence.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<T[]> ToArrayAsync(CancellationToken cancellationToken);

        //
        // Summary:
        //     Creates a System.Collections.Generic.Dictionary<TKey,TValue> from an System.Linq.IQueryable<T>
        //     by enumerating it asynchronously according to a specified key selector function.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to create a System.Collections.Generic.Dictionary<TKey,TValue>
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     a System.Collections.Generic.Dictionary<TKey,TValue> that contains selected
        //     keys and values.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<Dictionary<TKey, T>> ToDictionaryAsync<TKey>(Func<T, TKey> keySelector);
        //
        // Summary:
        //     Creates a System.Collections.Generic.Dictionary<TKey,TValue> from an System.Linq.IQueryable<T>
        //     by enumerating it asynchronously according to a specified key selector function.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to create a System.Collections.Generic.Dictionary<TKey,TValue>
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     a System.Collections.Generic.Dictionary<TKey,TValue> that contains selected
        //     keys and values.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<Dictionary<TKey, T>> ToDictionaryAsync<TKey>(Func<T, TKey> keySelector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Creates a System.Collections.Generic.Dictionary<TKey,TValue> from an System.Linq.IQueryable<T>
        //     by enumerating it asynchronously according to a specified key selector and
        //     an element selector function.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to create a System.Collections.Generic.Dictionary<TKey,TValue>
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   elementSelector:
        //     A transform function to produce a result element value from each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector .
        //
        //   TElement:
        //     The type of the value returned by elementSelector.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     a System.Collections.Generic.Dictionary<TKey,TValue> that contains values
        //     of type TElement selected from the input sequence.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TKey, TElement>(Func<T, TKey> keySelector, Func<T, TElement> elementSelector);
        //
        // Summary:
        //     Creates a System.Collections.Generic.Dictionary<TKey,TValue> from an System.Linq.IQueryable<T>
        //     by enumerating it asynchronously according to a specified key selector function
        //     and a comparer.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to create a System.Collections.Generic.Dictionary<TKey,TValue>
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer<T> to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     a System.Collections.Generic.Dictionary<TKey,TValue> that contains selected
        //     keys and values.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<Dictionary<TKey, T>> ToDictionaryAsync<TKey>(Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer);
        //
        // Summary:
        //     Creates a System.Collections.Generic.Dictionary<TKey,TValue> from an System.Linq.IQueryable<T>
        //     by enumerating it asynchronously according to a specified key selector and
        //     an element selector function.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to create a System.Collections.Generic.Dictionary<TKey,TValue>
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   elementSelector:
        //     A transform function to produce a result element value from each element.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector .
        //
        //   TElement:
        //     The type of the value returned by elementSelector.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     a System.Collections.Generic.Dictionary<TKey,TValue> that contains values
        //     of type TElement selected from the input sequence.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TKey, TElement>(Func<T, TKey> keySelector, Func<T, TElement> elementSelector, CancellationToken cancellationToken);
        //
        // Summary:
        //     Creates a System.Collections.Generic.Dictionary<TKey,TValue> from an System.Linq.IQueryable<T>
        //     by enumerating it asynchronously according to a specified key selector function,
        //     a comparer, and an element selector function.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to create a System.Collections.Generic.Dictionary<TKey,TValue>
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   elementSelector:
        //     A transform function to produce a result element value from each element.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer<T> to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector .
        //
        //   TElement:
        //     The type of the value returned by elementSelector.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     a System.Collections.Generic.Dictionary<TKey,TValue> that contains values
        //     of type TElement selected from the input sequence.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TKey, TElement>(Func<T, TKey> keySelector, Func<T, TElement> elementSelector, IEqualityComparer<TKey> comparer);
        //
        // Summary:
        //     Creates a System.Collections.Generic.Dictionary<TKey,TValue> from an System.Linq.IQueryable<T>
        //     by enumerating it asynchronously according to a specified key selector function
        //     and a comparer.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to create a System.Collections.Generic.Dictionary<TKey,TValue>
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer<T> to compare keys.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector .
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     a System.Collections.Generic.Dictionary<TKey,TValue> that contains selected
        //     keys and values.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<Dictionary<TKey, T>> ToDictionaryAsync<TKey>(Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken);
        //
        // Summary:
        //     Creates a System.Collections.Generic.Dictionary<TKey,TValue> from an System.Linq.IQueryable<T>
        //     by enumerating it asynchronously according to a specified key selector function,
        //     a comparer, and an element selector function.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to create a System.Collections.Generic.Dictionary<TKey,TValue>
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   elementSelector:
        //     A transform function to produce a result element value from each element.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer<T> to compare keys.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector .
        //
        //   TElement:
        //     The type of the value returned by elementSelector.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     a System.Collections.Generic.Dictionary<TKey,TValue> that contains values
        //     of type TElement selected from the input sequence.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TKey, TElement>(Func<T, TKey> keySelector, Func<T, TElement> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken);

        //
        // Summary:
        //     Creates a System.Collections.Generic.List<T> from an System.Linq.IQueryable<T>
        //     by enumerating it asynchronously.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to create a System.Collections.Generic.List<T>
        //     from.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     a System.Collections.Generic.List<T> that contains elements from the input
        //     sequence.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<List<T>> ToListAsync();        
        //
        // Summary:
        //     Creates a System.Collections.Generic.List<T> from an System.Linq.IQueryable<T>
        //     by enumerating it asynchronously.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to create a list from.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     a System.Collections.Generic.List<T> that contains elements from the input
        //     sequence.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<List<T>> ToListAsync(CancellationToken cancellationToken);

        //
        // Summary:
        //     Sorts the elements of a sequence in ascending order according to a key.
        //
        // Parameters:
        //   source:
        //     A sequence of values to order.
        //
        //   keySelector:
        //     A function to extract a key from an element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by the function that is represented by keySelector.
        //
        // Returns:
        //     An System.Linq.IOrderedQueryable<T> whose elements are sorted according to
        //     a key.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or keySelector is null.
        IOrderedQueryBuilder<T> OrderBy<TKey>(Expression<Func<T, TKey>> keySelector);
        //
        // Summary:
        //     Sorts the elements of a sequence in ascending order by using a specified
        //     comparer.
        //
        // Parameters:
        //   source:
        //     A sequence of values to order.
        //
        //   keySelector:
        //     A function to extract a key from an element.
        //
        //   comparer:
        //     An System.Collections.Generic.IComparer<T> to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by the function that is represented by keySelector.
        //
        // Returns:
        //     An System.Linq.IOrderedQueryable<T> whose elements are sorted according to
        //     a key.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or keySelector or comparer is null.
        IOrderedQueryBuilder<T> OrderBy<TKey>(Expression<Func<T, TKey>> keySelector, IComparer<TKey> comparer);
        //
        // Summary:
        //     Sorts the elements of a sequence in descending order according to a key.
        //
        // Parameters:
        //   source:
        //     A sequence of values to order.
        //
        //   keySelector:
        //     A function to extract a key from an element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by the function that is represented by keySelector.
        //
        // Returns:
        //     An System.Linq.IOrderedQueryable<T> whose elements are sorted in descending
        //     order according to a key.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or keySelector is null.
        IOrderedQueryBuilder<T> OrderByDescending<TKey>(Expression<Func<T, TKey>> keySelector);
        //
        // Summary:
        //     Sorts the elements of a sequence in descending order by using a specified
        //     comparer.
        //
        // Parameters:
        //   source:
        //     A sequence of values to order.
        //
        //   keySelector:
        //     A function to extract a key from an element.
        //
        //   comparer:
        //     An System.Collections.Generic.IComparer<T> to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by the function that is represented by keySelector.
        //
        // Returns:
        //     An System.Linq.IOrderedQueryable<T> whose elements are sorted in descending
        //     order according to a key.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or keySelector or comparer is null.
        IOrderedQueryBuilder<T> OrderByDescending<TKey>(Expression<Func<T, TKey>> keySelector, IComparer<TKey> comparer);

        //
        // Summary:
        //     Filters a sequence of values based on a predicate.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to filter.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An System.Linq.IQueryable<T> that contains elements from the input sequence
        //     that satisfy the condition specified by predicate.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null.
        IQueryBuilder<T> Where(Expression<Func<T, bool>> predicate);
        //
        // Summary:
        //     Filters a sequence of values based on a predicate. Each element's index is
        //     used in the logic of the predicate function.
        //
        // Parameters:
        //   source:
        //     An System.Linq.IQueryable<T> to filter.
        //
        //   predicate:
        //     A function to test each element for a condition; the second parameter of
        //     the function represents the index of the element in the source sequence.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An System.Linq.IQueryable<T> that contains elements from the input sequence
        //     that satisfy the condition specified by predicate.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null.
        IQueryBuilder<T> Where(Expression<Func<T, int, bool>> predicate);

        IQueryBuilder<T> Page(int page, int pageSize);

        //
        // Summary:
        //     Creates a System.Collections.Generic.List<T> from an System.Collections.Generic.IEnumerable<T>.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable<T> to create a System.Collections.Generic.List<T>
        //     from.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A System.Collections.Generic.List<T> that contains elements from the input
        //     sequence.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null.
        List<T> ToList();

        //
        // Summary:
        //     Returns the first element of a sequence, or a default value if the sequence
        //     contains no elements.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable<T> to return the first element
        //     of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     default(TSource) if source is empty; otherwise, the first element in source.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null.
        T FirstOrDefault();
        //
        // Summary:
        //     Returns the first element of the sequence that satisfies a condition or a
        //     default value if no such element is found.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable<T> to return an element from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     default(TSource) if source is empty or if no element passes the test specified
        //     by predicate; otherwise, the first element in source that passes the test
        //     specified by predicate.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or predicate is null.
        T FirstOrDefault(Func<T, bool> predicate);
    }
}
