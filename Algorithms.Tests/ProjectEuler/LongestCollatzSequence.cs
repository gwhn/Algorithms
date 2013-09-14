using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class LongestCollatzSequence
    {
        private readonly Code.ProjectEuler.LongestCollatzSequence _unit = new Code.ProjectEuler.LongestCollatzSequence();

        [TestMethod]
        public void Test1()
        {
            const int max = 1000000;
            var result = _unit.Solve(max);
            Assert.IsTrue(result == 837799);
        }
    }
}
