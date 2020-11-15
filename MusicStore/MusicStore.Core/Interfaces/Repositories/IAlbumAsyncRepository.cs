// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAlbumAsyncRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The AlbumAsyncRepository interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Core.Interfaces.Repositories
{
    using MusicStore.Core.Entities;

    /// <summary>
    /// The AlbumAsyncRepository interface.
    /// </summary>
    public interface IAlbumAsyncRepository : IAsyncRepository<Album>
    {
    }
}
