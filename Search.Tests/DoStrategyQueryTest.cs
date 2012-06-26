using System.Collections.Generic;
using Core.common;
using Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Search.Tests
{   
   [TestClass()]
    public class DoStrategyQueryTest
   {
       private readonly IList<String> _searchlist;

       public DoStrategyQueryTest()
        {
            _searchlist = new List<string> {"1", "1", "2", "3", "4"};
        }

       [TestMethod]
       public void EqualityTest()
       {
            IList<SearchElement<string>> list = new List<SearchElement<string>>();
            list.Add(new SearchElement<string> { Obj = "1", Oprs = OperatorType.Equals });
           
           var search = new DoStrategyQuery<String>(list, _searchlist.AsQueryable(),SearchFactory.GetInstanceOfSearchFactoru());
            Assert.AreEqual(2, search.ExecuteSearch().Count());
       } 
       [TestMethod]
       public void NotEqualityTest()
       {
            IList<SearchElement<string>> list = new List<SearchElement<string>>();
            list.Add(new SearchElement<string> { Obj = "1", Oprs = OperatorType.NotEquals });

            var search = new DoStrategyQuery<String>(list, _searchlist.AsQueryable(), SearchFactory.GetInstanceOfSearchFactoru());
            Assert.AreEqual(3, search.ExecuteSearch().Count());
       }

       [TestMethod]
       public void LessThanTest()
       {
           IList<SearchElement<string>> list = new List<SearchElement<string>>();
           list.Add(new SearchElement<string> { Obj = "2", Oprs = OperatorType.LessThan });

           var search = new DoStrategyQuery<String>(list, _searchlist.AsQueryable(), SearchFactory.GetInstanceOfSearchFactoru());
           Assert.AreEqual(2, search.ExecuteSearch().Count());
       }

       [TestMethod]
       public void GreaterThanTest()
       {
           IList<SearchElement<string>> list = new List<SearchElement<string>>();
           list.Add(new SearchElement<string> { Obj = "1", Oprs = OperatorType.Greaterthan });

           var search = new DoStrategyQuery<String>(list, _searchlist.AsQueryable(), SearchFactory.GetInstanceOfSearchFactoru());
           Assert.AreEqual(3, search.ExecuteSearch().Count());
       }

       [TestMethod]
       public void LessThanEqualsTest()
       {
           IList<SearchElement<string>> list = new List<SearchElement<string>>();
           list.Add(new SearchElement<string> { Obj = "2", Oprs = OperatorType.LessThanEquals });

           var search = new DoStrategyQuery<String>(list, _searchlist.AsQueryable(), SearchFactory.GetInstanceOfSearchFactoru());
           Assert.AreEqual(3, search.ExecuteSearch().Count());
       }

       [TestMethod]
       public void GreaterThanEqualsTest()
       {
           IList<SearchElement<string>> list = new List<SearchElement<string>>();
           list.Add(new SearchElement<string> { Obj = "2", Oprs = OperatorType.GreaterthanEquals });

           var search = new DoStrategyQuery<String>(list, _searchlist.AsQueryable(), SearchFactory.GetInstanceOfSearchFactoru());
           Assert.AreEqual(3, search.ExecuteSearch().Count());
       }

    }
}
