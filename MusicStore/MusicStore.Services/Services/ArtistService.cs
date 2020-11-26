// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ArtistService.cs" company="">
//   
// </copyright>
// <summary>
//   The artist extended service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Services
{
    using Artist;
    using Grpc.Core;
    using MediatR;
    using Microsoft.Extensions.Logging;
    using MusicStore.Business.Queries;
    using System.Linq;
    using System.Threading.Tasks;

    using MusicStore.Business.Commands.Artists;
    using MusicStore.Services.Mappers;

    /// <summary>
    /// The artist extended service.
    /// </summary>
    public class ArtistExtendedService : ArtistService.ArtistServiceBase
    {
        private readonly ILogger<ArtistExtendedService> _logger;

        private readonly IMediator _mediator;

        public ArtistExtendedService(ILogger<ArtistExtendedService> logger, IMediator mediator)
        {
            this._logger = logger;
            this._mediator = mediator;
        }

        /// <summary>
        /// The artist list paginate.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public override async Task<ArtistListPaginatedResponse> ArtistListPaginate(ArtistListPaginatedRequest request, ServerCallContext context)
        {            
            var output = new ArtistListPaginatedResponse();

            var result = await this._mediator.Send(new ArtistFilterPaginatedQuery{ Name = request.Name, Page = request.PageIndex, PageSize = request.PageSize });

            output.TotalItems = result.TotalItems;

            result.Items.ToList().ForEach(a => output.Items.Add(a.Map()));

            return output;
            
        }

        /// <summary>
        /// The create artist.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public override async Task<CreateArtistResponse> CreateArtist(CreateArtistRequest request, ServerCallContext context)
        {
            var output = new CreateArtistResponse();
            var result = await this._mediator.Send(
                             new ArtistCreateCommand
                                 {
                                     ArtisticName = request.Artist.ArtisticName,
                                     Name = request.Artist.Name,
                                     DateOfBirth = request.Artist.DateOfBirth.ToDateTime()
                                 });

            output.Sucess = result.Success;

            return output;
        }
    }
}
