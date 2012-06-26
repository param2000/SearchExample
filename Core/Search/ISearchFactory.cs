using Core.Common;
using Core.Operators;

namespace Core.Search
{
    public interface ISearchFactory
    {
        ISearch GetSearchImplementation(OperatorType type);
    }
}