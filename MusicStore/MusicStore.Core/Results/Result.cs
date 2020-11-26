// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Result.cs" company="">
//   
// </copyright>
// <summary>
//   The result.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Core.Results
{
    using MusicStore.Core.Interfaces;

    /// <summary>
    /// The result.
    /// </summary>
    /// <typeparam name="TData">
    /// </typeparam>
    public class Result<TData> : Result, IResult<TData>
    where TData : class
    {
        public TData Data { get; set; }
    }
    /// <summary>
    /// The result.
    /// </summary>
    public class Result : IResult
    {
        public bool Success { get; set; }
    }
}