// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ArtistCreateCommandHandler.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ArtistCreateCommandHandler type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Business.Commands.Handlers
{
    using System.Threading;
    using System.Threading.Tasks;

    using MediatR;

    using MusicStore.Business.Commands.Artists;
    using MusicStore.Core.Entities;
    using MusicStore.Core.Interfaces;
    using MusicStore.Core.Interfaces.Repositories;
    using MusicStore.Core.Results;

    /// <summary>
    /// The artist create command handler.
    /// </summary>
    public class ArtistCreateCommandHandler : IRequestHandler<ArtistCreateCommand,IResult>
    {
        /// <summary>
        /// The artist async repository.
        /// </summary>
        private readonly IArtistAsyncRepository _artistAsyncRepository;

        /// <summary>
        /// The unit of work.
        /// </summary>
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistCreateCommandHandler"/> class.
        /// </summary>
        /// <param name="artistAsyncRepository">
        /// The artist async repository.
        /// </param>
        /// <param name="unitOfWork">
        /// The unit of work.
        /// </param>
        public ArtistCreateCommandHandler(IArtistAsyncRepository artistAsyncRepository, IUnitOfWork unitOfWork)
        {
            this._artistAsyncRepository = artistAsyncRepository;
            this._unitOfWork = unitOfWork;
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
        public async Task<IResult> Handle(ArtistCreateCommand request, CancellationToken cancellationToken)
        {
            var output = new Result();

            var artist = new Artist(request.Name, request.DateOfBirth, request.ArtisticName);

            await this._artistAsyncRepository.AddAsync(artist);

            await this._unitOfWork.SaveChangesAsync();

            output.Success = true;

            return output;
        }
    }
}
