// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IResult.cs" company="">
//   
// </copyright>
// <summary>
//   The Result interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Core.Interfaces
{
    /// <summary>
    /// The Result interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IResult<T> : IResult
        where T : class
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public T Data { get; set; }
    }

    /// <summary>
    /// The Result interface.
    /// </summary>
    public interface IResult
    {
        /// <summary>
        /// Gets a value indicating whether success.
        /// </summary>
        bool Success {get;set;}
    }
}