// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ArtistConfiguration.cs" company="">
//   
// </copyright>
// <summary>
//   The artist configuration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Infra.Persistence.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using MusicStore.Core.Entities;

    /// <summary>
    /// The artist configuration.
    /// </summary>
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        /// <summary>
        /// The configure.
        /// </summary>
        /// <param name="builder">
        /// The builder.
        /// </param>
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
        }
    }
}
