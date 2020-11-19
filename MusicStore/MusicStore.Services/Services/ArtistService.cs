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
    using Grpc.Core;
    using Microsoft.Extensions.Logging;
    using System.Threading.Tasks;

    /// <summary>
    /// The artist extended service.
    /// </summary>
    public class ArtistExtendedService : ArtistService.ArtistServiceBase
    {
        private readonly ILogger<GreeterService> _logger;

        public ArtistExtendedService(ILogger<GreeterService> logger)
        {
            this._logger = logger;
        }

        public override Task<ArtistListPaginatedResponse> ArtistListPaginate(ArtistListPaginatedRequest request, ServerCallContext context)
        {
            return base.ArtistListPaginate(request, context);

            var t = new ArtistListPaginatedResponse() { }
        }
    }
}
