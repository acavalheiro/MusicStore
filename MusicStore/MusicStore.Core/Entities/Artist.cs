// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Artist.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Artist type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Core.Entities
{
    using System;

    /// <summary>
    /// The artist.
    /// </summary>
    public class Artist : Person
    {

        protected Artist()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Artist"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="dateOfBirth">
        /// The date of birth.
        /// </param>
        /// <param name="artisticName">
        /// The artistic name.
        /// </param>
        public Artist(string name, DateTime dateOfBirth, string artisticName)
            : base(name, dateOfBirth)
        {
            this.ArtisticName = artisticName;
        }

        /// <summary>
        /// Gets or sets the artistic name.
        /// </summary>
        public string ArtisticName { get; set; }
    }

    /// <summary>
    /// The composer.
    /// </summary>
    public class Composer : Person
    {
        public Composer(string name, DateTime dateOfBirth, string composerType)
            : base(name, dateOfBirth)
        {
            this.ComposerType = composerType;
        }

        /// <summary>
        /// Gets or sets the composer.
        /// </summary>
        public string ComposerType { get; set; }
    }
}
