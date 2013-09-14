using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class NumberLetterCounts
    {
        private readonly Code.ProjectEuler.NumberLetterCounts _unit = new Code.ProjectEuler.NumberLetterCounts();

        [TestMethod]
        public void Test1()
        {
            const int from = 1;
            const int to = 5;
            var result = _unit.Solve(from, to);
            Assert.IsTrue(result == 19);
        }

        [TestMethod]
        public void Test2()
        {
            const int from = 1;
            const int to = 1000;
            var result = _unit.Solve(from, to);
            Assert.IsTrue(result == 21124);
        }
    }
}
