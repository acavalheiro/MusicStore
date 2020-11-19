// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQueryResult.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IQueryResult type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Core.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// The QueryPaginatedResult interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IQueryPaginatedResult<T> : IQueryResult<T>
    where T : class
    {
        /// <summary>
        /// Gets or sets the total items.
        /// </summary>
        public int TotalItems {get;set;}
    }

    /// <summary>
    /// The QueryResult interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IQueryResult<T>
    where T : class
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public IEnumerable<T> Items {get;set;}

       
    }
}
