using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class DoubleBasePalindromes
    {
        private readonly Code.ProjectEuler.DoubleBasePalindromes _unit = new Code.ProjectEuler.DoubleBasePalindromes();

        [TestMethod]
        public void Test1()
        {
            const int max = 1000000;
            var result = _unit.Solve(max);
            Assert.IsTrue(result == 872187);
        }
    }
}
