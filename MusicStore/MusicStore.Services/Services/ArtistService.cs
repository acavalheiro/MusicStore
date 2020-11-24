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

        public async override Task<ArtistListPaginatedResponse> ArtistListPaginate(ArtistListPaginatedRequest request, ServerCallContext context)
        {            
            var output = new ArtistListPaginatedResponse();

            var result = await this._mediator.Send(new ArtistFilterPaginatedQuery{ Name = request.Name, Page = request.PageIndex, PageSize = request.PageSize });

            output.TotalItems = result.TotalItems;

            result.Items.ToList().ForEach(a => output.Items.Add(new ArtistItem { Name = a.Name }));

            return output;
            
        }
    }
}
