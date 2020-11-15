// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISpecificationEvaluator.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ISpecificationEvaluator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Core.Interfaces
{
    using System.Linq;

    /// <summary>
    /// The SpecificationEvaluator interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface ISpecificationEvaluator<T> where T : class
    {
        IQueryable<TResult> GetQuery<TResult>(IQueryable<T> inputQuery, ISpecification<T, TResult> specification);
        IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> specification);
    }
}