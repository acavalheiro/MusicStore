// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ArtistAsyncRepositoryTest.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ArtistAsyncRepositoryTest type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Xunit;

namespace MusicStore.Infra.Persistence.Tests
{
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using MusicStore.Core.Entities;
    using MusicStore.Core.Interfaces.Repositories;
    using MusicStore.Infra.Persistence.Context;
    using MusicStore.Infra.Persistence.Repositories;

    /// <summary>
    /// The artist async repository test.
    /// </summary>
    public abstract class ArtistAsyncRepositoryTest
    {
        /// <summary>
        /// Gets the context options.
        /// </summary>
        protected DbContextOptions<ApplicationContext> ContextOptions { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistAsyncRepositoryTest"/> class.
        /// </summary>
        /// <param name="contextOptions">
        /// The context options.
        /// </param>
        protected ArtistAsyncRepositoryTest(DbContextOptions<ApplicationContext> contextOptions)
        {
            ContextOptions = contextOptions;
            
            Seed();
        }

        /// <summary>
        /// The seed.
        /// </summary>
        private void Seed()
        {
            using (var context = new ApplicationContext(ContextOptions))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var one = new Artist("Andre", new System.DateTime(1987, 11, 27), "GentleMan");
                
                var two = new Artist("Filipe", new System.DateTime(2000, 11, 1), "Bla");
                
                var three = new Artist("Sofia", new System.DateTime(1980, 11, 06), "Teste");

                var four = new Composer("Composer", new System.DateTime(1980, 11, 06), "Bla");
                
                context.AddRange(one, two, three, four);
                
                context.SaveChanges();
            }
        }

        [Fact]
        public async Task GetAllArtists()
        {
            using (var context = new ApplicationContext(ContextOptions))
            {
                IArtistAsyncRepository repository = new ArtistAsyncRepository(context);

                var items = await repository.ListAllAsync();
                
                Assert.Equal(3, items.Count);
            }
        }

        [Fact]
        public async Task GetAllComposers()
        {
            using (var context = new ApplicationContext(ContextOptions))
            {
                var repository = new AsyncRepository<Person>(context);

                var items = await repository.ListAllAsync();
                
                Assert.Equal(4, items.Count);
            }
        }
    }
}
