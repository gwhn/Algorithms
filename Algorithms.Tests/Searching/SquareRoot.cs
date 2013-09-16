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
            var result = Code.Searching.SquareRoot.Calculate(n);
            Assert.IsTrue(result > 9.0D - 1e-3 && result < 9.0D + 1e-3);
        }

        [TestMethod]
        public void Test2()
        {
            const double n = 2.618D;
            var result = Code.Searching.SquareRoot.Calculate(n);
            Assert.IsTrue(result > 1.618D - 1e-3 && result < 1.618D + 1e-3);
        }
    }
}
