using System;
using System.Collections.Generic;
using System.Linq;
using Core.StrategyPattern;
using Core.common;

namespace Infrastructure
{
    public class DoStrategyQuery<T> : IDoStrategyQuery<T> where T:IComparable
    {
        private readonly IList<SearchElement<T>> _list;
        private IQueryable<T> _query;
        private readonly ISearchFactory _searchFactory;
        public DoStrategyQuery(IList<SearchElement<T>> list, IQueryable<T> query,ISearchFactory factory)
        {
            if (query == null) throw new ArgumentNullException("query");
            if (list == null) throw new ArgumentNullException("list");
            if (factory == null) throw new ArgumentNullException("factory");

            _list = list;
            _query = query;
            _searchFactory = factory;
        }

        public IQueryable<T> ExecuteSearch()
        {
            foreach (var searchElement in _list)
            {
                 _query = new DoSearch(_searchFactory.GetSearchImplementation(searchElement.Oprs)).PerformSearch(  _query ,searchElement.Obj);
            }
            return _query;
        }
    }
}