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
        /// /// Creates a raw SQL query that will return elements of the given generic type. The type can be any type that has properties
        /// that match the names of the columns returned from the query, or can be a simple primitive type. The type does not have to
        /// be an entity type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        ISqlQuery<T> SqlQuery<T>(string sql, params object[] parameters);

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
