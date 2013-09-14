using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class PowerDigitSum
    {
        private readonly Code.ProjectEuler.PowerDigitSum _unit = new Code.ProjectEuler.PowerDigitSum();

        [TestMethod]
        public void Test1()
        {
            const int n = 2;
            const int p = 15;
            var result = _unit.Sum(n, p);
            Assert.IsTrue(result == 26);
        }

        [TestMethod]
        public void Test2()
        {
            const int n = 2;
            const int p = 1000;
            var result = _unit.Sum(n, p);
            Assert.IsTrue(result == 1366);
        }
    }
}
