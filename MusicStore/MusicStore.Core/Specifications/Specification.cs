// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Specification.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Specification type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Core.Specification
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    using MusicStore.Core.Interfaces;

    /// <summary>
    /// The specification.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public abstract class Specification<T> : ISpecification<T>
    {
        public IList<Expression<Func<T, bool>>> WhereExpressions { get; } = new List<Expression<Func<T, bool>>>();

        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();
        public List<string> IncludeStrings { get; } = new List<string>();
        public Expression<Func<T, object>> OrderBy { get; private set; }
        public Expression<Func<T, object>> OrderByDescending { get; private set; }

        /// <summary>
        /// Gets the take.
        /// </summary>
        public int Take { get; private set; }

        /// <summary>
        /// Gets the skip.
        /// </summary>
        public int Skip { get; private set; }

        /// <summary>
        /// Gets a value indicating whether is paging enabled.
        /// </summary>
        public bool IsPagingEnabled { get; private set;}

        /// <summary>
        /// Gets the group by.
        /// </summary>
        public Expression<Func<T, object>> GroupBy { get; private set; }

        /// <summary>
        /// The paginate.
        /// </summary>
        /// <param name="skip">
        /// The skip.
        /// </param>
        /// <param name="take">
        /// The take.
        /// </param>
        public void Paginate(int skip, int take)
        {
            this.IsPagingEnabled = true;
            this.Skip = skip;
            this.Take = take;

        }

        /// <summary>
        /// The add where.
        /// </summary>
        /// <param name="where">
        /// The where.
        /// </param>
        public void AddWhere(Expression<Func<T, bool>> where)
        {
            this.WhereExpressions.Add(where);
        }
    }
}
