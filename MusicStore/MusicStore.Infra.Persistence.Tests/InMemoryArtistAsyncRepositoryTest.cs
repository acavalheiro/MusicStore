// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InMemoryArtistAsyncRepositoryTest.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the InMemoryArtistAsyncRepositoryTest type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



namespace MusicStore.Infra.Persistence.Tests
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Options;

    using MusicStore.Infra.Persistence.Context;

    public class InMemoryArtistAsyncRepositoryTest : ArtistAsyncRepositoryTest
    {
        public InMemoryArtistAsyncRepositoryTest()
            : base(
                new DbContextOptionsBuilder<ApplicationContext>().UseInMemoryDatabase("test").Options)
        {
        }
    }

   
}
