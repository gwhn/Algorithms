using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class SumSquareDifference
    {
        private readonly Code.ProjectEuler.SumSquareDifference _unit = new Code.ProjectEuler.SumSquareDifference();

        [TestMethod]
        public void Test1()
        {
            const int n = 10;
            var result = _unit.Calculate(n);
            Assert.IsTrue(result == 2640);
        }

        [TestMethod]
        public void Test2()
        {
            const int n = 100;
            var result = _unit.Calculate(n);
            Assert.IsTrue(result == 25164150);
        }
    }
}
