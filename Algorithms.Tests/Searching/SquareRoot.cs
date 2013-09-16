using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.Searching
{
    [TestClass]
    public class SquareRoot
    {
        [TestMethod]
        public void Test1()
        {
            const double n = 81.0D;
            const double p = 1e-3;
            var result = Code.Searching.SquareRoot.Calculate(n, p);
            Assert.IsTrue(result > 9.0D - p && result < 9.0D + p);
        }

        [TestMethod]
        public void Test2()
        {
            const double n = 2.618D;
            const double p = 1e-3;
            var result = Code.Searching.SquareRoot.Calculate(n, p);
            Assert.IsTrue(result > 1.618D - p && result < 1.618D + p);
        }
    }
}
