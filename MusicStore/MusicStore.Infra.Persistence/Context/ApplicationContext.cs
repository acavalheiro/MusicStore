// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationContext.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ApplicationContext type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



namespace MusicStore.Infra.Persistence.Context
{
    using System.Reflection;

    using Microsoft.EntityFrameworkCore;

    using MusicStore.Core.Entities;

    /// <summary>
    /// The application context.
    /// </summary>
    public class ApplicationContext : DbContext
    {

        public DbSet<Person> Persons { get; set; }


        /// <summary>
        /// Gets or sets the artists.
        /// </summary>
        public DbSet<Artist> Artists { get; set; }

        /// <summary>
        /// Gets or sets the composers.
        /// </summary>
        public DbSet<Composer> Composers { get; set; }

        public DbSet<Album> Albuns { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationContext"/> class.
        /// </summary>
        /// <param name="options">
        /// The options.
        /// </param>
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        /// <summary>
        /// The on model creating.
        /// </summary>
        /// <param name="builder">
        /// The builder.
        /// </param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
