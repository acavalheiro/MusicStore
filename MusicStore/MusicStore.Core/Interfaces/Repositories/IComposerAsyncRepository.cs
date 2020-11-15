// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IComposerAsyncRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The ComposerAsyncRepository interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Core.Interfaces.Repositories
{
    using MusicStore.Core.Entities;

    /// <summary>
    /// The ComposerAsyncRepository interface.
    /// </summary>
    public interface IComposerAsyncRepository : IAsyncRepository<Composer>
    {
    }
}