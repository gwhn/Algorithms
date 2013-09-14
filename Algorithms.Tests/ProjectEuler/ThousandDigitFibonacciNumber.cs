using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class ThousandDigitFibonacciNumber
    {
        private readonly Code.ProjectEuler.ThousandDigitFibonacciNumber _unit = new Code.ProjectEuler.ThousandDigitFibonacciNumber();

        [TestMethod]
        public void Test1()
        {
            const int n = 3;
            var result = _unit.Solve(n);
            Assert.IsTrue(result == 12);
        }

        [TestMethod]
        public void Test2()
        {
            const int n = 1000;
            var result = _unit.Solve(n);
            Assert.IsTrue(result == 4782);
        }
    }
}
