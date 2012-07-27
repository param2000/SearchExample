using System;
using System.Collections.Generic;
using System.Linq;
using Core.Operators;
using Core.Search;
using Core.Common;
using Infrastructure.Operators;

namespace Infrastructure.Search
{
    //Singleton class
    public class SearchFactory : ISearchFactory
    {
        private static IList<ISearch> _operators = new List<ISearch>()
                                                  {
                                                      new EqualSearch(),
                                                      new NotEqualSearch(),
                                                      new LessThanSearch(),
                                                      new GreaterThanSearch(),
                                                      new LessThanEqualSearch(),
                                                      new GreaterThanEqualSearch()
                                                  };
        private static SearchFactory _searchFactory;
        private SearchFactory()
        {}
        public static ISearchFactory GetInstanceOfSearchFactoru()
        {
            return _searchFactory ?? (_searchFactory = new SearchFactory());
        }
        
        public ISearch GetSearchImplementation(OperatorType type)
        {
            return _operators.First(s => s.CanHandle(type));
        }
    }
}