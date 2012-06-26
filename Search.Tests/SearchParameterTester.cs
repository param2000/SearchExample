using System.Collections.Generic;
using System.Linq;
using Core;
using Core.DifferentImplementation;
using Core.common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Search.Tests
{
    [TestClass]
    public class SearchParameterTester
    {
        [TestMethod]
        public void SearchParameterConstructorShouldInitializeValuesCorrectly()
        {

            IList<string> searchlist = new List<string>();
            searchlist.Add("1");
            searchlist.Add("1");
            searchlist.Add("2");
            searchlist.Add("3");
            searchlist.Add("4");

            IList<SearchElement<string>> list = new List<SearchElement<string>>();
            list.Add(new SearchElement<string>() { Obj = "1", Oprs = OperatorType.Equals });
            list.Add(new SearchElement<string>() { Obj = "1", Oprs = OperatorType.Equals });

            var search = new PerformSearch<string>(list, searchlist.AsQueryable());
            Assert.AreEqual(2,search.ExecuteSearch().Count());
        }

      
    }
}
