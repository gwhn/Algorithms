using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class SelfPowers
    {
        private readonly Code.ProjectEuler.SelfPowers _unit = new Code.ProjectEuler.SelfPowers();

        [TestMethod]
        public void Test1()
        {
            const int n = 1000;
            var result = _unit.Solve(n);
            Assert.IsTrue(result == "9110846700");
        }
    }
}
