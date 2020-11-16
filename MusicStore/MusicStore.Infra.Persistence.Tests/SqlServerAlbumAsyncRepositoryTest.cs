// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SqlServerArtistAsyncRepositoryTest.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the SqlServerArtistAsyncRepositoryTest type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Infra.Persistence.Tests
{
    using Microsoft.EntityFrameworkCore;

    using MusicStore.Infra.Persistence.Context;

    /// <summary>
    /// The sql server artist async repository test.
    /// </summary>
    public class SqlServerAlbumAsyncRepositoryTest : AlbumAsyncRepositoryTest
    {
        public SqlServerAlbumAsyncRepositoryTest()
            : base(
                new DbContextOptionsBuilder<ApplicationContext>()
                    .UseSqlServer(@"Server=.;Database=MusicStore;Trusted_Connection=True;")
                    .Options)
        {
        }
    }
}
