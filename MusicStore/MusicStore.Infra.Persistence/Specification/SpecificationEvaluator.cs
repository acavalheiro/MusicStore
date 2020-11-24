﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpecificationEvaluator.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the SpecificationEvaluatorBase type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MusicStore.Infra.Persistence.Specification
{
    using System.Linq;

    using Microsoft.EntityFrameworkCore;

    using MusicStore.Core.Entities;
    using MusicStore.Core.Interfaces;

    /// <summary>
    /// The specification evaluator.
    /// </summary>
    /// <typeparam name="TEntity">
    /// </typeparam>
    public class SpecificationEvaluator<TEntity> where TEntity : BaseEntity
    {
        public IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> specification)
        {
            var query = inputQuery;

            if (specification.WhereExpressions.Any())
            {
                var where = specification.WhereExpressions.Aggregate(
                    query,
                    (current, criteria) => current.Where(criteria));
            }


            // Includes all expression-based includes
            query = specification.Includes.Aggregate(query,
                (current, include) => current.Include(include));

            // Include any string-based include statements
            query = specification.IncludeStrings.Aggregate(query,
                (current, include) => current.Include(include));

            // Apply ordering if expressions are set
            if (specification.OrderBy != null)
            {
                query = query.OrderBy(specification.OrderBy);
            }
            else if (specification.OrderByDescending != null)
            {
                query = query.OrderByDescending(specification.OrderByDescending);
            }

            if (specification.IsPagingEnabled)
            {

                if (specification.Skip != 0)
                {
                    query = query.Skip(specification.Skip);
                }

            


                query = query.Skip(specification.Skip)
                    .Take(specification.Take);
            }

            return query;
        }
    }
}
