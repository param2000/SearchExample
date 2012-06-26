using System;
using Core.StrategyPattern;
using Core.common;
using Infrastructure.Operators;

namespace Infrastructure
{
    //Singleton class
    public class SearchFactory : ISearchFactory
    {
        private static SearchFactory _searchFactory;
        private SearchFactory()
        {}
        public static ISearchFactory GetInstanceOfSearchFactoru()
        {
            return _searchFactory ?? (_searchFactory = new SearchFactory());
        }
        
        public ISearch GetSearchImplementation(OperatorType type)
        {
            //TODO This implementation is not pretty need to remove so many iffs 
            // this whole operation can be replaced by container logic
             if (type == OperatorType.Equals)
                 return new EqualSearch();
                if (type == OperatorType.NotEquals)
                  return new NotEqualSearch();
                if (type == OperatorType.LessThan)
                    return new LessThanSearch();
                if (type == OperatorType.Greaterthan)
                    return new GreaterThanSearch();
                if (type == OperatorType.LessThanEquals)
                    return new LessThanEqualSearch();
                if (type == OperatorType.GreaterthanEquals)
                    return new GreaterThanEqualSearch();
               
           throw new NotImplementedException("Cannot find the implementation of the operator");
        }
    }
}