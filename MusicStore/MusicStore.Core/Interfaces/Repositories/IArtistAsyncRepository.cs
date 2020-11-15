// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IArtistAsyncRepository.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IArtistAsyncRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Core.Interfaces.Repositories
{
    using MusicStore.Core.Entities;

    /// <summary>
    /// The ArtistAsyncRepository interface.
    /// </summary>
    public interface IArtistAsyncRepository : IAsyncRepository<Artist>
    {
    }
}