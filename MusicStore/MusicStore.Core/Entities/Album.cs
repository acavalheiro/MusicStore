// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Album.cs" company="">
//   
// </copyright>
// <summary>
//   The album.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Core.Entities
{
    using System;

    /// <summary>
    /// The album.
    /// </summary>
    public class Album : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Album"/> class.
        /// </summary>
        protected Album()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Album"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="albumType">
        /// The album type.
        /// </param>
        /// <param name="artistId">
        /// The artist id.
        /// </param>
        public Album(string name, AlbumType albumType, Guid artistId)
        {
            this.Name = name;
            this.AlbumType = albumType;
            this.ArtistId = artistId;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the type.
        /// </summary>
        public AlbumType AlbumType { get; }

        /// <summary>
        /// Gets the artist id.
        /// </summary>
        public Guid ArtistId {get; }

        /// <summary>
        /// Gets the artist.
        /// </summary>
        public virtual Artist Artist { get; private set; }
    }
}
