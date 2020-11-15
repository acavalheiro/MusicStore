// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseEntity.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the BaseEntity type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Domain.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The base entity.
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public virtual Guid Id { get; protected set; }

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        [Timestamp]
        public byte[] Timestamp { get; set; }

        public virtual int RowVersion { get; protected set; }


    }

}
