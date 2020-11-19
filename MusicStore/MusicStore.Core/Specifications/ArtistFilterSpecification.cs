// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ArtistFilterSpecification.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ArtistFilterSpecification type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Core.Specifications
{
    using MusicStore.Core.Entities;
    using MusicStore.Core.Specification;

    /// <summary>
    /// The artist filter specification.
    /// </summary>
    public class ArtistFilterSpecification : Specification<Artist>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistFilterSpecification"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public ArtistFilterSpecification(string name)
        {
            this.AddWhere(i => i.Name.Contains(name));
        }
    }

    /// <summary>
    /// The artist filter pagination specification.
    /// </summary>
    public class ArtistFilterPaginationSpecification : ArtistFilterSpecification
    {
        public ArtistFilterPaginationSpecification(string name, int page, int pageSize)
            : base(name)
        {
            this.Paginate(page * pageSize, pageSize);
        }
    }
}
