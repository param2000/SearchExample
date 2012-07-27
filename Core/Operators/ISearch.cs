using System;
using System.Linq;
using Core.Common;

namespace Core.Operators
{
    public interface ISearch
    {
        IQueryable<T> Search<T>(IQueryable<T> query, T value) where T : IComparable;
        bool CanHandle(OperatorType type);
    }
}