// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RequestPaginatedBase.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the RequestPaginatedBase type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Business.Infra
{
    public class RequestPaginatedBase
    {
        public int PageSize { get; set; }

        public int Page { get; set; }

    }
}
