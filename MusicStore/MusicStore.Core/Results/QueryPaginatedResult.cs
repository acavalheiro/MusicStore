// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryPaginatedResult.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the QueryPaginatedResult type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Core.Results
{
    using MusicStore.Core.Interfaces;

    /// <summary>
    /// The query paginated result.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class QueryPaginatedResult<T> : QueryResult<T> , IQueryPaginatedResult<T>
    where T : class
    {
        public int TotalItems { get; set; }
    }
}