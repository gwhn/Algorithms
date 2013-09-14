using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class QuadraticPrimes
    {
        private readonly Code.ProjectEuler.QuadraticPrimes _unit = new Code.ProjectEuler.QuadraticPrimes();

        [TestMethod]
        public void Test1()
        {
            const int mina = -1000;
            const int maxa = 1000;
            const int minb = -1000;
            const int maxb = 1000;
            var result = _unit.Solve(mina, maxa, minb, maxb);
            Assert.IsTrue(result == -59231);
        }
    }
}
