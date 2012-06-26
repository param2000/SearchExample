using System;
using System.Linq;

namespace Core.DifferentImplementation
{
    public static class Extensions
    {
        public static IQueryable<T> EqualsSearch<T>(this IQueryable<T> query, T value)
        {
            if (query != null )
                return query.Where(e => e.Equals(value));
            return query;
        }

        public static IQueryable<object> NotEqualsSearch(this IQueryable<object> query, object value)
        {
            if (query != null && value != null)
                return query.Where(e => !e.Equals(value));
            return query;
        }
        public static IQueryable<T> LessThanSearch<T>(this IQueryable<T> query, T value) where T : IComparable
        {
            if (query != null)
                return query.Where(e => e.CompareTo(value) < 0);
            return query;
        }


        public static IQueryable<T> Search<T>(this IQueryable<T> query, T value)
        {
            if (query != null)
                return query.Where(e => e.Equals(value));
            return null;
        }
    }

   
}