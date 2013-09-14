using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class SummationOfPrimes
    {
        private readonly Code.ProjectEuler.SummationOfPrimes _unit = new Code.ProjectEuler.SummationOfPrimes();

        [TestMethod]
        public void Test1()
        {
            const int n = 10;
            var result = _unit.Sum(n);
            Assert.IsTrue(result == 17);
        }

        [TestMethod]
        public void Test2()
        {
            const int n = 2000000;
            var result = _unit.Sum(n);
            Assert.IsTrue(result == 142913828922);
        }
    }
}
