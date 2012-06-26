using System;
using System.Linq;

namespace Core.StrategyPattern
{
    public class NotEqualSearch : ISearch
    {
       public IQueryable<T> Search<T>(IQueryable<T> query, T value) where T : IComparable
        {
            if (query != null)
                query = query.Where(e => e.CompareTo(value)!=0);
                //query = query.Where(e => !e.Equals(value)); // every object has equals

            return query;
        }
    }
}