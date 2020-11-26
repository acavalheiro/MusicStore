// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ArtistMapper.cs" company="">
//   
// </copyright>
// <summary>
//   The artist mapper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Services.Mappers
{
    using Artist;

    using MusicStore.Core.Entities;

    /// <summary>
    /// The artist mapper.
    /// </summary>
    public static class ArtistMapper
    {
        /// <summary>
        /// The map.
        /// </summary>
        /// <param name="source">
        /// The source.
        /// </param>
        /// <returns>
        /// The <see cref="ArtistItem"/>.
        /// </returns>
        public static ArtistItem Map(this Artist source) =>
            new()
                {
                    Id = source.Id.ToString("N"),
                    Name = source.Name,
                    DateOfBirth =
                        Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(
                            source.DateOfBirth.ToUniversalTime()),
                    ArtisticName = source.ArtisticName
                };
    }
}
