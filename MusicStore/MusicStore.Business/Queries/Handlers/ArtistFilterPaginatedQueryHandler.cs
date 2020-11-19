// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ArtistFilterPaginatedQueryHandler.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ArtistFilterPaginatedQueryHandler type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Business.Queries.Handlers
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using MediatR;

    using MusicStore.Core.Entities;
    using MusicStore.Core.Interfaces;
    using MusicStore.Core.Interfaces.Repositories;
    using MusicStore.Core.Results;
    using MusicStore.Core.Specifications;

    /// <summary>
    /// The artist filter paginated query handler.
    /// </summary>
    public class ArtistFilterPaginatedQueryHandler : IRequestHandler<ArtistFilterPaginatedQuery,IQueryPaginatedResult<Artist>>
    {
        /// <summary>
        /// The artist async repository.
        /// </summary>
        private readonly IArtistAsyncRepository _artistAsyncRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistFilterPaginatedQueryHandler"/> class.
        /// </summary>
        /// <param name="artistAsyncRepository">
        /// The artist async repository.
        /// </param>
        public ArtistFilterPaginatedQueryHandler(IArtistAsyncRepository artistAsyncRepository)
        {
            this._artistAsyncRepository = artistAsyncRepository;
        }

        /// <summary>
        /// The handle.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="cancellationToken">
        /// The cancellation token.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<IQueryPaginatedResult<Artist>> Handle(ArtistFilterPaginatedQuery request, CancellationToken cancellationToken)
        {

            var totalItems = await this._artistAsyncRepository.CountAsync(new ArtistFilterSpecification(request.Name));
            var items = await this._artistAsyncRepository.ListAsync(
                            new ArtistFilterPaginationSpecification(request.Name, request.Page, request.Page));

            var output = new QueryPaginatedResult<Artist> { Items = items, TotalItems = totalItems };

            return output;


        }
    }
}
