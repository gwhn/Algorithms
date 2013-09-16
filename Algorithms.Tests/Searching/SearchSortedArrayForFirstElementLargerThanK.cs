using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.Searching
{
    [TestClass]
    public class SearchSortedArrayForFirstElementLargerThanK
    {
        [TestMethod]
        public void Test1()
        {
            var a = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            const int k = 7;
            var result = Code.Searching.SearchSortedArrayForFirstElementLargerThanK.IndexOf(a, k);
            Assert.IsTrue(result == 7);
        }
    }
}
