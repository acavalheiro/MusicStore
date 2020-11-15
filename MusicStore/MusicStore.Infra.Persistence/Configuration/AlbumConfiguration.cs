// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AlbumConfiguration.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the AlbumConfiguration type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Infra.Persistence.Configuration
{
    using System;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using MusicStore.Domain.Entities;

    /// <summary>
    /// The album configuration.
    /// </summary>
    public class AlbumConfiguration: IEntityTypeConfiguration<Album>
    {
        /// <summary>
        /// The configure.
        /// </summary>
        /// <param name="builder">
        /// The builder.
        /// </param>
        public void Configure(EntityTypeBuilder<Album> builder)
        {

            builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
        }
    }
}
