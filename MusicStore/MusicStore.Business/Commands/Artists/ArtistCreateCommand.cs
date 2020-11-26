// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ArtistCreateCommand.cs" company="">
//   
// </copyright>
// <summary>
//   The artist create command.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Business.Commands.Artists
{
    using System;

    using MediatR;

    using MusicStore.Core.Interfaces;

    /// <summary>
    /// The artist create command.
    /// </summary>
    public class ArtistCreateCommand : IRequest<IResult>
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the artistic name.
        /// </summary>
        public string ArtisticName { get; set; }
    }
}