using Core.Common;

namespace Core.Search
{
    public interface ISearchFactory
    {
        ISearch GetSearchImplementation(OperatorType type);
    }
}