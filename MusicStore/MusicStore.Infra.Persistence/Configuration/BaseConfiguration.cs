// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseConfiguration.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the BaseConfiguration type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Infra.Persistence.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using MusicStore.Domain.Entities;

    /// <summary>
    /// The base configuration.
    /// </summary>
    public class BaseConfiguration : IEntityTypeConfiguration<BaseEntity>
    {
        public void Configure(EntityTypeBuilder<BaseEntity> builder)
        {
            builder.Property(p => p.RowVersion).IsRowVersion();
        }
    }
}