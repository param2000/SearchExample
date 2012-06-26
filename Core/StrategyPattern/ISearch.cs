using System;
using System.Linq;

namespace Core.StrategyPattern
{
    public interface ISearch
    {
        IQueryable<T> Search<T>(IQueryable<T> query, T value) where T : IComparable;
    }
}