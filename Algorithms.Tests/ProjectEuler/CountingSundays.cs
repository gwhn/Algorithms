using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class CountingSundays
    {
        private readonly Code.ProjectEuler.CountingSundays _unit = new Code.ProjectEuler.CountingSundays();

        [TestMethod]
        public void Test1()
        {
            var from = new DateTime(1901, 1, 1);
            var to = new DateTime(2000, 12, 31);
            var result = _unit.Solve(from, to);
            Assert.IsTrue(result == 171);
        }
    }
}
