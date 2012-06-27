using System;
using System.Linq;
using Core.Operators;
using Core.Search;

namespace Infrastructure.Search
{
    public class DoSearch : IDoSearch
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