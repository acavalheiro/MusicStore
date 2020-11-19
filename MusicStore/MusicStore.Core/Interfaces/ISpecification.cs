// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISpecification.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ISpecification type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



namespace MusicStore.Core.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// The Specification interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface ISpecification<T>
    {

        /// <summary>
        /// Gets the where expressions.
        /// </summary>
        IList<Expression<Func<T, bool>>> WhereExpressions { get; }

        /// <summary>
        /// Gets the includes.
        /// </summary>
        List<Expression<Func<T, object>>> Includes { get; }

        /// <summary>
        /// Gets the include strings.
        /// </summary>
        List<string> IncludeStrings { get; }

        /// <summary>
        /// Gets the order by.
        /// </summary>
        Expression<Func<T, object>> OrderBy { get; }

        /// <summary>
        /// Gets the order by descending.
        /// </summary>
        Expression<Func<T, object>> OrderByDescending { get; }

        /// <summary>
        /// Gets the take.
        /// </summary>
        int Take { get; }

        /// <summary>
        /// Gets the skip.
        /// </summary>
        int Skip { get; }

        /// <summary>
        /// Gets a value indicating whether is paging enabled.
        /// </summary>
        bool IsPagingEnabled { get; }
    }

    
}
