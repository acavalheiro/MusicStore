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
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        List<string> IncludeStrings { get; }

        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
    }

    /// <summary>
    /// The Specification interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    /// <typeparam name="TResult">
    /// </typeparam>
    public interface ISpecification<T, TResult> : ISpecification<T>
    {
        Expression<Func<T, TResult>>? Selector { get; }
    }
}
