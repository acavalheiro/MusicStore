// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AsyncRepository.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the AsyncRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Infra.Persistence.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using MusicStore.Core.Entities;
    using MusicStore.Core.Interfaces;
    using MusicStore.Infra.Persistence.Context;
    using MusicStore.Infra.Persistence.Specification;

    /// <summary>
    /// The async repository.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class AsyncRepository<T> : IAsyncRepository<T> where T : BaseEntity, IAggregateRoot
    {
        /// <summary>
        /// The _context.
        /// </summary>
        protected readonly ApplicationContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncRepository{T}"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public AsyncRepository(ApplicationContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// The get by id async.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await this._context.Set<T>().FindAsync(id);
        }

        /// <summary>
        /// The list all async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await this._context.Set<T>().ToListAsync();
        }

        /// <summary>
        /// The list async.
        /// </summary>
        /// <param name="spec">
        /// The spec.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            var specificationResult = this.ApplySpecification(spec);
            return await specificationResult.ToListAsync();
        }

        /// <summary>
        /// The count async.
        /// </summary>
        /// <param name="spec">
        /// The spec.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            var specificationResult = this.ApplySpecification(spec);
            return await specificationResult.CountAsync();
        }

        /// <summary>
        /// The add async.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<T> AddAsync(T entity)
        {
            await this._context.Set<T>().AddAsync(entity);
            await this._context.SaveChangesAsync();

            return entity;
        }

        /// <summary>
        /// The update async.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task UpdateAsync(T entity)
        {
            this._context.Entry(entity).State = EntityState.Modified;
            await this._context.SaveChangesAsync();
        }

        /// <summary>
        /// The delete async.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task DeleteAsync(T entity)
        {
            this._context.Set<T>().Remove(entity);
            await this._context.SaveChangesAsync();
        }

        /// <summary>
        /// The first async.
        /// </summary>
        /// <param name="spec">
        /// The spec.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<T> FirstAsync(ISpecification<T> spec)
        {
            var specificationResult = this.ApplySpecification(spec);
            return await specificationResult.FirstAsync();
        }

        /// <summary>
        /// The first or default async.
        /// </summary>
        /// <param name="spec">
        /// The spec.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<T> FirstOrDefaultAsync(ISpecification<T> spec)
        {
            var specificationResult = this.ApplySpecification(spec);
            return await specificationResult.FirstOrDefaultAsync();
        }

        /// <summary>
        /// The apply specification.
        /// </summary>
        /// <param name="spec">
        /// The spec.
        /// </param>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            var evaluator = new SpecificationEvaluator<T>();
            return evaluator.GetQuery(this._context.Set<T>().AsQueryable(), spec);
        }
    }
}
