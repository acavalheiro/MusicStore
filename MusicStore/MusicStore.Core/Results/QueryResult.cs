// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryResult.cs" company="">
//   
// </copyright>
// <summary>
//   The query result.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Core.Results
{
    using MusicStore.Core.Interfaces;
    using System.Collections.Generic;

    /// <summary>
    /// The query result.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class QueryResult<T> : IQueryResult<T>
    where T : class
    {
        public IEnumerable<T> Items { get; set; }
    }
}
