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
    public class QueryBuilder<T> : IQueryBuilder<T>, IOrderedQueryBuilder<T>
    {
        private DbContext context;       
        private IExceptionHandler exceptionHandler;

        internal IQueryable<T> Query { get; set; }

        public QueryBuilder(DbContext context):this(context,new ExceptionHandler(),null)
        {
        }

        public QueryBuilder(DbContext context, IExceptionHandler exceptionHandler): this(context,exceptionHandler,null)
        {            
        }

        public QueryBuilder(DbContext context, IExceptionHandler exceptionHandler, IQueryable<T> query)
        {
            if(context == null)
            {
                throw new ArgumentNullException("context");
            }

            this.context = context;
            this.exceptionHandler = exceptionHandler;                       
            
            if (query != null)
            {
                this.Query = query;
            }
            else
            {

                if (typeof(T).IsValueType)
                {
                    throw new ArgumentException("The type 'T' must be a reference type in order to use it as parameter.");
                }

                Type TRef = typeof(T);

                MethodInfo setMethod = typeof(DbContext).GetMethods().Where(sm => sm.Name == "Set" && sm.IsGenericMethod).FirstOrDefault();
                MethodInfo setMethodGeneric = setMethod.MakeGenericMethod(new Type[] { TRef });

                this.Query = (IQueryable<T>) setMethodGeneric.Invoke(this.context, new object[] {});
            }
        }

        #region IQueryable<T> implementation

        public IEnumerator<T> GetEnumerator()
        {
            return this.Query.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.Query.GetEnumerator();
        }

        public Type ElementType
        {
            get {
                return this.Query.ElementType;
            }
        }

        public System.Linq.Expressions.Expression Expression
        {
            get {
                return this.Query.Expression;
            }
        }

        public IQueryProvider Provider
        {
            get {
                return this.Query.Provider;
            }
        }

        #endregion

        #region All

        public Task<bool> AllAsync(Expression<Func<T, bool>> predicate)
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

        public Task<bool> AllAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
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

        #endregion

        #region Any

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

        public Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
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

        public Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.AnyAsync(predicate,cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        #endregion

        #region Average

        public Task<decimal?> AverageAsync(Expression<Func<T, decimal?>> selector)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<decimal> AverageAsync(Expression<Func<T, decimal>> selector)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }
        
        public Task<double?> AverageAsync(Expression<Func<T, double?>> selector)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }
        
        public Task<double> AverageAsync(Expression<Func<T, double>> selector)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }
        
        public Task<float?> AverageAsync(Expression<Func<T, float?>> selector)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }
        
        public Task<float> AverageAsync(Expression<Func<T, float>> selector)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }
        
        public Task<double?> AverageAsync(Expression<Func<T, int?>> selector)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }
        
        public Task<double> AverageAsync(Expression<Func<T, int>> selector)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }
        
        public Task<double?> AverageAsync(Expression<Func<T, long?>> selector)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }
        
        public Task<double> AverageAsync(Expression<Func<T, long>> selector)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }
        
        public Task<decimal?> AverageAsync(Expression<Func<T, decimal?>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }
        
        public Task<decimal> AverageAsync(Expression<Func<T, decimal>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }
        
        public Task<double?> AverageAsync(Expression<Func<T, double?>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }
        
        public Task<double> AverageAsync(Expression<Func<T, double>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }
        
        public Task<float?> AverageAsync(Expression<Func<T, float?>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }
        
        public Task<float> AverageAsync(Expression<Func<T, float>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }
        
        public Task<double?> AverageAsync(Expression<Func<T, int?>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }
        
        public Task<double> AverageAsync(Expression<Func<T, int>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }
        
        public Task<double?> AverageAsync(Expression<Func<T, long?>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.AverageAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }


        #endregion

        #region Contains

        public Task<bool> ContainsAsync(T item)
        {
            try
            {
                return this.Query.ContainsAsync(item);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<bool> ContainsAsync(T item, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.ContainsAsync(item,cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        #endregion

        #region Count

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

        public Task<int> CountAsync(Expression<Func<T, bool>> predicate)
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

        public Task<int> CountAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
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

        #endregion

        #region First

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

        public Task<T> FirstAsync(Expression<Func<T, bool>> predicate)
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

        public Task<T> FirstAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.FirstAsync(predicate,cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        #endregion

        #region FirstOrDefault

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

        public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
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

        public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
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

        #endregion

        #region Foreach

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

        public Task ForEachAsync(Action<object> action)
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
                return this.Query.ForEachAsync(action, cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task ForEachAsync(Action<object> action, CancellationToken cancellationToken)
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

        #endregion

        #region Include
      
        public IQueryBuilder<T> Include<TProperty>(Expression<Func<T, TProperty>> path)
        {
            if (typeof(T).IsValueType)
            {
                throw new ArgumentException("T");
            }

            Type TRef = typeof(T);

            MethodInfo include = typeof(QueryableExtensions).GetMethods().Where(mi => mi.Name == "Include" && mi.CustomAttributes.Count() > 1).FirstOrDefault();
            MethodInfo includeGeneric = include.MakeGenericMethod(new Type[] { TRef, typeof(TProperty) });

            try
            {                                
                this.Query = (IQueryable<T>)includeGeneric.Invoke(null, new object[] { this.Query, path });

                return this;
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public IQueryBuilder<T> Include(string path)
        {
            if (typeof(T).IsValueType)
            {
                throw new ArgumentException("T");
            }

            Type TRef = typeof(T);

            MethodInfo include = typeof(QueryableExtensions).GetMethods().Where(mi => mi.Name == "Include" && mi.CustomAttributes.Count() < 2).FirstOrDefault();
            MethodInfo includeGeneric = include.MakeGenericMethod(new Type[] { TRef});

            try
            {
                this.Query = (IQueryable<T>)includeGeneric.Invoke(null, new object[] { this.Query, path });

                return this;
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        #endregion

        #region LongCount

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

        public Task<long> LongCountAsync(Expression<Func<T, bool>> predicate)
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

        public Task<long> LongCountAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.LongCountAsync(predicate,cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        #endregion

        #region MaxAsync

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

        public Task<TResult> MaxAsync<TResult>(Expression<Func<T, TResult>> selector)
        {
            try
            {
                return this.Query.MaxAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<TResult> MaxAsync<TResult>(Expression<Func<T, TResult>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.MaxAsync(selector,cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        #endregion

        #region MinAsync

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

        public Task<TResult> MinAsync<TResult>(Expression<Func<T, TResult>> selector)
        {
            try
            {
                return this.Query.MinAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<TResult> MinAsync<TResult>(Expression<Func<T, TResult>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.MinAsync(selector, cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        #endregion

        #region Select

        public IQueryBuilder<TResult> Select<TResult>(Expression<Func<T, TResult>> selector)
        {
            try
            {
                return new QueryBuilder<TResult>(this.context,this.exceptionHandler,this.Query.Select(selector));
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        #endregion

        #region SingleAsync

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

        public Task<T> SingleAsync(Expression<Func<T, bool>> predicate)
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

        public Task<T> SingleAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
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

        #endregion

        #region SingleOrDefaultAsync

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

        public Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
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

        public Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
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

        #endregion

        #region Skip

        public IQueryBuilder<T> Skip(Expression<Func<int>> countAccessor)
        {
            try
            {
                this.Query = this.Query.Skip(countAccessor);
                return this;
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public IQueryBuilder<T> Skip(int count)
        {
            try
            {
                this.Query = this.Query.Skip(count);
                return this;
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        #endregion

        #region SumAsync

        public Task<decimal?> SumAsync(Expression<Func<T, decimal?>> selector)
        {
            try
            {
                return this.Query.SumAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<decimal> SumAsync(Expression<Func<T, decimal>> selector)
        {
            try
            {
                return this.Query.SumAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<double?> SumAsync(Expression<Func<T, double?>> selector)
        {
            try
            {
                return this.Query.SumAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<double> SumAsync(Expression<Func<T, double>> selector)
        {
            try
            {
                return this.Query.SumAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<float?> SumAsync(Expression<Func<T, float?>> selector)
        {
            try
            {
                return this.Query.SumAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<float> SumAsync(Expression<Func<T, float>> selector)
        {
            try
            {
                return this.Query.SumAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<int?> SumAsync(Expression<Func<T, int?>> selector)
        {
            try
            {
                return this.Query.SumAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<int> SumAsync(Expression<Func<T, int>> selector)
        {
            try
            {
                return this.Query.SumAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<long?> SumAsync(Expression<Func<T, long?>> selector)
        {
            try
            {
                return this.Query.SumAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<long> SumAsync(Expression<Func<T, long>> selector)
        {
            try
            {
                return this.Query.SumAsync(selector);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<decimal?> SumAsync(Expression<Func<T, decimal?>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.SumAsync(selector,cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<decimal> SumAsync(Expression<Func<T, decimal>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.SumAsync(selector,cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<double?> SumAsync(Expression<Func<T, double?>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.SumAsync(selector, cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<double> SumAsync(Expression<Func<T, double>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.SumAsync(selector, cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<float?> SumAsync(Expression<Func<T, float?>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.SumAsync(selector, cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<float> SumAsync(Expression<Func<T, float>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.SumAsync(selector, cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<int?> SumAsync(Expression<Func<T, int?>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.SumAsync(selector, cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<int> SumAsync(Expression<Func<T, int>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.SumAsync(selector, cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<long?> SumAsync(Expression<Func<T, long?>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.SumAsync(selector, cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<long> SumAsync(Expression<Func<T, long>> selector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.SumAsync(selector, cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        #endregion

        #region Take

        public IQueryBuilder<T> Take(Expression<Func<int>> countAccessor)
        {
            try
            {
                this.Query = this.Query.Take(countAccessor);

                return this;
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public IQueryBuilder<T> Take(int count)
        {
            try
            {
                this.Query = this.Query.Take(count);

                return this;
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        #endregion

        #region ToArray

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

        #endregion ToDictionaryAsync

        #region ToDictionary

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

        public Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TKey, TElement>(Func<T, TKey> keySelector, Func<T, TElement> elementSelector)
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
                return this.Query.ToDictionaryAsync(keySelector,comparer);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TKey, TElement>(Func<T, TKey> keySelector, Func<T, TElement> elementSelector, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.ToDictionaryAsync(keySelector,elementSelector,cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TKey, TElement>(Func<T, TKey> keySelector, Func<T, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        {
            try
            {
                return this.Query.ToDictionaryAsync(keySelector,elementSelector,comparer);
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
                return this.Query.ToDictionaryAsync(keySelector,comparer,cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TKey, TElement>(Func<T, TKey> keySelector, Func<T, TElement> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
        {
            try
            {
                return this.Query.ToDictionaryAsync(keySelector,elementSelector,comparer,cancellationToken);
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        #endregion

        #region OrderBy

        public IOrderedQueryBuilder<T> OrderBy<TKey>(Expression<Func<T, TKey>> keySelector)
        {
            try
            {
                this.Query = this.Query.OrderBy(keySelector);

                return this as IOrderedQueryBuilder<T>;
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public IOrderedQueryBuilder<T> OrderBy<TKey>(string propertyName)
        {
            try
            {
                this.Query = OrderBy(propertyName, true);

                return this as IOrderedQueryBuilder<T>;
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        internal IQueryable<T> OrderBy(string propertyName, bool ascending)
        {
            var parameter = Expression.Parameter(typeof(T), "p");
            var property = Expression.Property(parameter, propertyName);
            var expression = Expression.Lambda(property, parameter);

            string method = ascending ? "OrderBy" : "OrderByDescending";

            Type[] types = new Type[] { this.Query.ElementType, expression.Body.Type };

            var methodCallExpression = Expression.Call(typeof(Queryable), method, types, this.Query.Expression, expression);

            return this.Query.Provider.CreateQuery<T>(methodCallExpression) as IOrderedQueryable<T>;
        }

        public IOrderedQueryBuilder<T> OrderBy<TKey>(Expression<Func<T, TKey>> keySelector, IComparer<TKey> comparer)
        {
            try
            {
                this.Query = this.Query.OrderBy(keySelector, comparer);

                return this as IOrderedQueryBuilder<T>;
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public IOrderedQueryBuilder<T> OrderByDescending<TKey>(Expression<Func<T, TKey>> keySelector)
        {
            try
            {
                this.Query = this.Query.OrderByDescending(keySelector);

                return this as IOrderedQueryBuilder<T>;
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public IOrderedQueryBuilder<T> OrderByDescending<TKey>(Expression<Func<T, TKey>> keySelector, IComparer<TKey> comparer)
        {
            try
            {
                this.Query = this.Query.OrderByDescending(keySelector,comparer);

                return this as IOrderedQueryBuilder<T>;
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public IOrderedQueryBuilder<T> OrderByDescending<TKey>(string propertyName)
        {
            try
            {
                this.Query = OrderBy(propertyName, false);

                return this as IOrderedQueryBuilder<T>;
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        #endregion

        #region ThenBy

        public IOrderedQueryBuilder<T> ThenBy<TKey>(Expression<Func<T,TKey>> keySelector)
        {
            try
            {
                this.Query = ((IOrderedQueryable<T>)this.Query).ThenBy(keySelector);

                return this;
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public IOrderedQueryBuilder<T> ThenBy<TKey>(Expression<Func<T, TKey>> keySelector, IComparer<TKey> comparer)
        {
            try
            {
                this.Query = ((IOrderedQueryable<T>)this.Query).ThenBy(keySelector, comparer);

                return this as IOrderedQueryBuilder<T>;
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public IOrderedQueryBuilder<T> ThenByDescending<TKey>(Expression<Func<T, TKey>> keySelector)
        {
            try
            {
                this.Query = ((IOrderedQueryable<T>)this.Query).ThenByDescending(keySelector);

                return this as IOrderedQueryBuilder<T>;
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        public IOrderedQueryBuilder<T> ThenByDescending<TKey>(Expression<Func<T, TKey>> keySelector, IComparer<TKey> comparer)
        {
            try
            {
                this.Query = ((IOrderedQueryable<T>)this.Query).ThenBy(keySelector, comparer);

                return this as IOrderedQueryBuilder<T>;
            }
            catch (Exception ex)
            {
                throw this.exceptionHandler.TranslateException(ex);
            }
        }

        #endregion

        #region Page

        public IQueryBuilder<T> Page(int page, int pageSize)
        {
            this.Query = this.Query.Skip(page * pageSize).Take(pageSize);
            return this;
        }

        #endregion

        #region Where

        public IQueryBuilder<T> Where(Expression<Func<T, bool>> predicate)
        {
            this.Query = this.Query.Where( predicate);
            return this;
        }

        public IQueryBuilder<T> Where(Expression<Func<T, int, bool>> predicate)
        {
            this.Query = this.Query.Where(predicate);
            return this;
        }

        #endregion

        #region ToList

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

        #endregion

        #region FirstOrDefault

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

        #endregion

        #region ToListAsync

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
        
        #endregion
    }
}
