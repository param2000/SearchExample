using System;
using System.Linq;

namespace Core.Operators
{
    public interface ISearch
    {
        IQueryable<T> Search<T>(IQueryable<T> query, T value) where T : IComparable;
    }
}