using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Genfr.Repository
{
    public interface IStore: IDisposable
    {
        /// <summary>
        /// Returns a QueryBuilder instance for access to entities of the given type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IQueryBuilder<T> Query<T>() where T : class;

        /// <summary>
        /// Asynchronously creates a new entity of type T and saves it.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task CreateAsync<T>(T entity) where T : class;

        /// <summary>
        /// Asynchronously updates an existing entity of type T and saves it.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task UpdateAsync<T>(T entity) where T : class;

        /// <summary>
        /// Asynchronously deletes an existing entity of type T and saves it.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task DeleteAsync<T>(T entity) where T : class;
    }
}
