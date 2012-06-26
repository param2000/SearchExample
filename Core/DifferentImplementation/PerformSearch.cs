using System.Collections.Generic;
using System.Linq;
using Core.common;

namespace Core.DifferentImplementation
{
    public class PerformSearch<T>
    {
        private readonly IList<SearchElement<T>> _list;
        private IQueryable<object> _query;
        public PerformSearch(IList<SearchElement<T>> list, IQueryable<object> query)
        {
            _list = list;
            //TODO throw exception if there is any element in list is null
            _query = query;
        }

        public IQueryable<object> ExecuteSearch()
        {
            foreach (var searchElement in _list)
            {
                if (searchElement.Oprs == OperatorType.Equals)
                    _query = _query.EqualsSearch(searchElement.Obj);
                 if (searchElement.Oprs == OperatorType.NotEquals)
                    _query = _query.NotEqualsSearch(searchElement.Obj);

               
            }
            return _query;
        }
    }
}