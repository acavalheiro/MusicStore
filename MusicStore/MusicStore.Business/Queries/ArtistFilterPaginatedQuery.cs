// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ArtistFilterPaginatedQuery.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ArtistFilterPaginatedQuery type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Business.Queries
{
    using MediatR;

    using MusicStore.Business.Infra;
    using MusicStore.Business.Infra.Interfaces;
    using MusicStore.Core.Entities;
    using MusicStore.Core.Interfaces;

    /// <summary>
    /// The artist filter paginated query.
    /// </summary>
    public class ArtistFilterPaginatedQuery : RequestPaginatedBase, IRequestPaginated<IQueryPaginatedResult<Artist>>
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }
    }
}
