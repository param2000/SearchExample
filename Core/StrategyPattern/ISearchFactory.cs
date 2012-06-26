using Core.common;

namespace Core.StrategyPattern
{
    public interface ISearchFactory
    {
        ISearch GetSearchImplementation(OperatorType type);
    }
}