using System;
using System.Linq;

namespace Core.StrategyPattern
{
    public interface IDoStrategyQuery<out T> where T : IComparable
    {
        IQueryable<T> ExecuteSearch();
    }
}