using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class IntegerRightTriangles
    {
        private readonly Code.ProjectEuler.IntegerRightTriangles _unit = new Code.ProjectEuler.IntegerRightTriangles();

        [TestMethod]
        public void Test1()
        {
            const int p = 1000;
            var result = _unit.Solve(p);
            Assert.IsTrue(result == 840);
        }
    }
}
