// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRequestPaginated.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IRequestPaginated type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Business.Infra.Interfaces
{
    using MediatR;

    using MusicStore.Core.Interfaces;

    /// <summary>
    /// The RequestPaginated interface.
    /// </summary>
    /// <typeparam name="TResponse">
    /// </typeparam>
    interface IRequestPaginated<out TResponse> : IRequest<TResponse>
    {
        /// <summary>
        /// Gets the page size.
        /// </summary>
        public int PageSize { get; set; }

        public int Page { get; set; }
    }
}
