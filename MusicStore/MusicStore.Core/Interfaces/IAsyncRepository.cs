// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAsyncRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The AsyncRepository interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Core.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using MusicStore.Core.Entities;

    /// <summary>
    /// The AsyncRepository interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IAsyncRepository<T> where T : BaseEntity, IAggregateRoot
    {
        /// <summary>
        /// The get by id async.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<T> GetByIdAsync(int id);

        /// <summary>
        /// The list all async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IReadOnlyList<T>> ListAllAsync();

        /// <summary>
        /// The list async.
        /// </summary>
        /// <param name="spec">
        /// The spec.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);

        /// <summary>
        /// The add async.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<T> AddAsync(T entity);

        /// <summary>
        /// The update async.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task UpdateAsync(T entity);

        /// <summary>
        /// The delete async.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task DeleteAsync(T entity);

        /// <summary>
        /// The count async.
        /// </summary>
        /// <param name="spec">
        /// The spec.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<int> CountAsync(ISpecification<T> spec);

        /// <summary>
        /// The first async.
        /// </summary>
        /// <param name="spec">
        /// The spec.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<T> FirstAsync(ISpecification<T> spec);

        /// <summary>
        /// The first or default async.
        /// </summary>
        /// <param name="spec">
        /// The spec.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<T> FirstOrDefaultAsync(ISpecification<T> spec);
    }
}
