using System;
using System.Linq;
using Core.Operators;

namespace Infrastructure.Operators
{
    public class EqualSearch : ISearch
    {
        public IQueryable<T> Search<T>(IQueryable<T> query, T value) where T : IComparable
        {
            if (query != null)
                query = query.Where(e => e.CompareTo(value) == 0);
               // query = query.Where(e => e.Equals(value));
            return query;
        }
    }
}