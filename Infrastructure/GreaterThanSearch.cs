using System;
using System.Linq;
using Core.StrategyPattern;

namespace Infrastructure
{
    public class GreaterThanSearch : ISearch
    {
        public IQueryable<T> Search<T>(IQueryable<T> query, T value) where T : IComparable
        {
            if (query != null)
                query = query.Where(e => e.CompareTo(value) > 0);

            return query;
        }
    }
}