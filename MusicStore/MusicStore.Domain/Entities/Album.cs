﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Album.cs" company="">
//   
// </copyright>
// <summary>
//   The album.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Domain.Entities
{
    using System;

    /// <summary>
    /// The album.
    /// </summary>
    public class Album : BaseEntity, Iagrr
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public AlbumType Type { get; set; }
    }
}
