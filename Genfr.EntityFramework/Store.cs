using Genfr.EntityFramework.ExceptionHandling;
using Genfr.Repository;
using Genfr.Repository.ExceptionHandling;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Genfr.EntityFramework
{
    public class Store : IStore
    {
        private bool disposed = false;
        public DbContext context;
        private IExceptionHandler ExceptionHandler;        

        public Store(DbContext context): this(context, new ExceptionHandler())
        {            
        }

        public Store(DbContext context, IExceptionHandler ExceptionHandler)
        {
            this.context = context;
            this.ExceptionHandler = ExceptionHandler;
        }

        public IQueryBuilder<T> Query<T>() where T : class
        {                                       
            return new QueryBuilder<T>(this.context);
        }

        public async Task CreateAsync<T>(T entity) where T : class
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            try
            {
                this.context.Set<T>().Add(entity);

                await this.context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw this.ExceptionHandler.TranslateException(ex);                
            }
        }

        public async Task UpdateAsync<T>(T entity) where T : class
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            try
            {
                if (!this.context.Set<T>().Local.Any(i => i == entity))
                {
                    this.context.Set<T>().Attach(entity);
                }

                this.context.Entry(entity).State = EntityState.Modified;

                await this.context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw this.ExceptionHandler.TranslateException(ex);                
            }
        }

        public async Task DeleteAsync<T>(T entity) where T : class
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            try
            {
                this.context.Entry(entity).State = EntityState.Deleted;
                
                await this.context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw this.ExceptionHandler.TranslateException(ex);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (!this.disposed & !this.disposed)
            {
                this.context.Dispose();
            }

            this.disposed = true;
            this.context = null;            
        }
    }
}
