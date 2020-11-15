// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ArtistAsyncRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The artist async repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Infra.Persistence.Repositories
{
    using MusicStore.Core.Entities;
    using MusicStore.Core.Interfaces.Repositories;
    using MusicStore.Infra.Persistence.Context;

    /// <summary>
    /// The artist async repository.
    /// </summary>
    public class ArtistAsyncRepository : AsyncRepository<Artist>, IArtistAsyncRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistAsyncRepository"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public ArtistAsyncRepository(ApplicationContext context)
            : base(context)
        {
        }
    }
}
