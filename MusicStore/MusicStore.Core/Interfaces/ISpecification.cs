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


        List<Expression<Func<T, object>>> Includes { get; }
        List<string> IncludeStrings { get; }

        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
    }

    
}
