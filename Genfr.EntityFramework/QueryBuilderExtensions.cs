using Genfr.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Threading;

namespace Genfr.EntityFramework
{
    public static class QueryBuilderExtensions
    {

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Decimal
        //     values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Decimal values to calculate the average of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public static Task<decimal?> AverageAsync(this IQueryBuilder<decimal?> source)
        {
            var queryBuilder = (QueryBuilder<decimal?>)source;
            return queryBuilder.Query.AverageAsync();
        }

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Decimal values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Decimal values to calculate the average of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        public static Task<decimal> AverageAsync(this IQueryBuilder<decimal> source)
        {
            var queryBuilder = (QueryBuilder<decimal>)source;
            return queryBuilder.Query.AverageAsync();
        }

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Double
        //     values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Double values to calculate the average of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public static Task<double?> AverageAsync(this IQueryBuilder<double?> source)
        {
            var queryBuilder = (QueryBuilder<double?>)source;
            return queryBuilder.Query.AverageAsync();
        }

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Double values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Double values to calculate the average of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        public static Task<double> AverageAsync(this IQueryBuilder<double> source)
        {
            var queryBuilder = (QueryBuilder<double>)source;
            return queryBuilder.Query.AverageAsync();
        }

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Single
        //     values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Single values to calculate the average of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public static Task<float?> AverageAsync(this IQueryBuilder<float?> source)
        {
            var queryBuilder = (QueryBuilder<float?>)source;
            return queryBuilder.Query.AverageAsync();
        }

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Single values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Single values to calculate the average of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        public static Task<float> AverageAsync(this IQueryBuilder<float> source)
        {
            var queryBuilder = (QueryBuilder<float>)source;
            return queryBuilder.Query.AverageAsync();
        }

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Int32
        //     values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Int32 values to calculate the average of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public static Task<double?> AverageAsync(this IQueryBuilder<int?> source)
        {
            var queryBuilder = (QueryBuilder<int?>)source;
            return queryBuilder.Query.AverageAsync();
        }

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Int32 values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Int32 values to calculate the average of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        public static Task<double> AverageAsync(this IQueryBuilder<int> source)
        {
            var queryBuilder = (QueryBuilder<int>)source;
            return queryBuilder.Query.AverageAsync();
        }

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Int64
        //     values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Int64 values to calculate the average of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public static Task<double?> AverageAsync(this IQueryBuilder<long?> source)
        {
            var queryBuilder = (QueryBuilder<long?>)source;
            return queryBuilder.Query.AverageAsync();
        }

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Int64 values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Int64 values to calculate the average of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        public static Task<double> AverageAsync(this IQueryBuilder<long> source)
        {
            var queryBuilder = (QueryBuilder<long>)source;
            return queryBuilder.Query.AverageAsync();          
        }

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Decimal
        //     values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Decimal values to calculate the average of.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public static Task<decimal?> AverageAsync(this IQueryBuilder<decimal?> source, CancellationToken cancellationToken)
        {
            var queryBuilder = (QueryBuilder<decimal?>)source;
            return queryBuilder.Query.AverageAsync(cancellationToken);          
        }

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Decimal values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Decimal values to calculate the average of.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        public static Task<decimal> AverageAsync(this IQueryBuilder<decimal> source, CancellationToken cancellationToken)
        {
            var queryBuilder = (QueryBuilder<decimal>)source;
            return queryBuilder.Query.AverageAsync(cancellationToken);
        }

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Double
        //     values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Double values to calculate the average of.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public static Task<double?> AverageAsync(this IQueryBuilder<double?> source, CancellationToken cancellationToken)
        {
            var queryBuilder = (QueryBuilder<double?>)source;
            return queryBuilder.Query.AverageAsync(cancellationToken);
        }

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Double values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Double values to calculate the average of.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        public static Task<double> AverageAsync(this IQueryBuilder<double> source, CancellationToken cancellationToken)
        {
            var queryBuilder = (QueryBuilder<double>)source;
            return queryBuilder.Query.AverageAsync(cancellationToken);
        }
        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Single
        //     values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Single values to calculate the average of.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public static Task<float?> AverageAsync(this IQueryBuilder<float?> source, CancellationToken cancellationToken)
        {
            var queryBuilder = (QueryBuilder<float?>)source;
            return queryBuilder.Query.AverageAsync(cancellationToken);
        }

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Single values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Single values to calculate the average of.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        public static Task<float> AverageAsync(this IQueryBuilder<float> source, CancellationToken cancellationToken)
        {
            var queryBuilder = (QueryBuilder<float>)source;
            return queryBuilder.Query.AverageAsync(cancellationToken);
        }

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Int32
        //     values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Int32 values to calculate the average of.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public static Task<double?> AverageAsync(this IQueryBuilder<int?> source, CancellationToken cancellationToken)
        {
            var queryBuilder = (QueryBuilder<int?>)source;
            return queryBuilder.Query.AverageAsync(cancellationToken);
        }

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Int32 values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Int32 values to calculate the average of.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        public static Task<double> AverageAsync(this IQueryBuilder<int> source, CancellationToken cancellationToken)
        {
            var queryBuilder = (QueryBuilder<int>)source;
            return queryBuilder.Query.AverageAsync(cancellationToken);
        }

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of nullable System.Int64
        //     values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Int64 values to calculate the average of.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public static Task<double?> AverageAsync(this IQueryBuilder<long?> source, CancellationToken cancellationToken)
        {
            var queryBuilder = (QueryBuilder<long?>)source;
            return queryBuilder.Query.AverageAsync(cancellationToken);
        }

        //
        // Summary:
        //     Asynchronously computes the average of a sequence of System.Int64 values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Int64 values to calculate the average of.
        //
        //   cancellationToken:
        //     A System.Threading.CancellationToken to observe while waiting for the task
        //     to complete.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the average of the sequence of values.
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
        //     source contains no elements.
        //
        // Remarks:
        //     Multiple active operations on the same context instance are not supported.
        //     Use 'await' to ensure that any asynchronous operations have completed before
        //     calling another method on this context.
        public static Task<double> AverageAsync(this IQueryBuilder<long> source, CancellationToken cancellationToken)
        {
            var queryBuilder = (QueryBuilder<long>)source;
            return queryBuilder.Query.AverageAsync(cancellationToken);
        }

        //
        // Summary:
        //     Asynchronously computes the sum of a sequence of nullable System.Decimal
        //     values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Decimal values to calculate the sum of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the values in the sequence.
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
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public static Task<decimal?> SumAsync(this IQueryBuilder<decimal?> source)
        {
            var queryBuilder = (QueryBuilder<decimal?>)source;
            return queryBuilder.Query.SumAsync();
        }

        //
        // Summary:
        //     Asynchronously computes the sum of a sequence of System.Decimal values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Decimal values to calculate the sum of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the values in the sequence.
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
        public static Task<decimal> SumAsync(this IQueryBuilder<decimal> source)
        {
            var queryBuilder = (QueryBuilder<decimal>)source;
            return queryBuilder.Query.SumAsync();
        }

        //
        // Summary:
        //     Asynchronously computes the sum of a sequence of nullable System.Double values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Double values to calculate the sum of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the values in the sequence.
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
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public static Task<double?> SumAsync(this IQueryBuilder<double?> source)
        {
            var queryBuilder = (QueryBuilder<double?>)source;
            return queryBuilder.Query.SumAsync();
        }

        //
        // Summary:
        //     Asynchronously computes the sum of a sequence of System.Double values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Double values to calculate the sum of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the values in the sequence.
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
        public static Task<double> SumAsync(this IQueryBuilder<double> source)
        {
            var queryBuilder = (QueryBuilder<double>)source;
            return queryBuilder.Query.SumAsync();
        }

        //
        // Summary:
        //     Asynchronously computes the sum of a sequence of nullable System.Single values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Single values to calculate the sum of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the values in the sequence.
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
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public static Task<float?> SumAsync(this IQueryBuilder<float?> source)
        {
            var queryBuilder = (QueryBuilder<float?>)source;
            return queryBuilder.Query.SumAsync();
        }

        //
        // Summary:
        //     Asynchronously computes the sum of a sequence of System.Single values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Single values to calculate the sum of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the values in the sequence.
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
        public static Task<float> SumAsync(this IQueryBuilder<float> source)
        {
            var queryBuilder = (QueryBuilder<float>)source;
            return queryBuilder.Query.SumAsync();
        }

        //
        // Summary:
        //     Asynchronously computes the sum of a sequence of nullable System.Int32 values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Int32 values to calculate the sum of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the values in the sequence.
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
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public static Task<int?> SumAsync(this IQueryBuilder<int?> source)
        {
            var queryBuilder = (QueryBuilder<int?>)source;
            return queryBuilder.Query.SumAsync();
        }

        //
        // Summary:
        //     Asynchronously computes the sum of a sequence of System.Int32 values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Int32 values to calculate the sum of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the values in the sequence.
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
        public static Task<int> SumAsync(this IQueryBuilder<int> source)
        {
            var queryBuilder = (QueryBuilder<int>)source;
            return queryBuilder.Query.SumAsync();
        }

        //
        // Summary:
        //     Asynchronously computes the sum of a sequence of nullable System.Int64 values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Int64 values to calculate the sum of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the values in the sequence.
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
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public static Task<long?> SumAsync(this IQueryBuilder<long?> source)
        {
            var queryBuilder = (QueryBuilder<long?>)source;
            return queryBuilder.Query.SumAsync();
        }

        //
        // Summary:
        //     Asynchronously computes the sum of a sequence of System.Int64 values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Int64 values to calculate the sum of.
        //
        // Returns:
        //     A task that represents the asynchronous operation.  The task result contains
        //     the sum of the values in the sequence.
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
        public static Task<long> SumAsync(this IQueryBuilder<long> source)
        {
            var queryBuilder = (QueryBuilder<long>)source;
            return queryBuilder.Query.SumAsync();
        }
    }
}
