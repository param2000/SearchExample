using System;
using System.Linq;

namespace Core.Search
{
    public interface IDoSearch
    {
        IQueryable<T> PerformSearch<T>(IQueryable<T> query, T value) where T : IComparable;
    }
}