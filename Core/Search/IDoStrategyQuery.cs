using System;
using System.Linq;

namespace Core.Search
{
    public interface IDoStrategyQuery<out T> where T : IComparable
    {
        IQueryable<T> ExecuteSearch();
    }
}