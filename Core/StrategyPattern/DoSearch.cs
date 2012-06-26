using System;
using System.Linq;

namespace Core.StrategyPattern
{
    public class DoSearch
    {
        private readonly ISearch _search;

        public DoSearch(ISearch search)
        {
            _search = search;
        }
        public IQueryable<T> PerformSearch<T>(IQueryable<T> query, T value) where T : IComparable
        {
            return _search.Search<T>(query, value);
        }
    }
}