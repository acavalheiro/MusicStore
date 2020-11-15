// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseEntity.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the BaseEntity type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Core.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using MusicStore.Core.Interfaces;

    /// <summary>
    /// The base entity.
    /// </summary>
    public abstract class BaseEntity : IAggregateRoot
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public virtual Guid Id { get; protected set; }

        /// <summary>
        /// Gets or sets the row version.
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; protected set; }


    }

}
