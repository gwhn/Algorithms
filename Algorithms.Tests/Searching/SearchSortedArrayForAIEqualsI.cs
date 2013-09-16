using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.Searching
{
    [TestClass]
    public class SearchSortedArrayForAIEqualsI
    {
        [TestMethod]
        public void Test1()
        {
            var a = new[] {-10, -5, -2, 0, 4, 8, 24};
            var result = Code.Searching.SearchSortedArrayForAIEqualsI.IndexOf(a);
            Assert.IsTrue(result == 4);
        }
    }
}
