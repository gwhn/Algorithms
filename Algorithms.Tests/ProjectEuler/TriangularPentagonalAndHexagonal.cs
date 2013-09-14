using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class TriangularPentagonalAndHexagonal
    {
        private readonly Code.ProjectEuler.TriangularPentagonalAndHexagonal _unit = new Code.ProjectEuler.TriangularPentagonalAndHexagonal();

        [TestMethod]
        public void Test1()
        {
            const int mint = 286;
            const int minp = 166;
            const int minh = 144;
            var result = _unit.Solve(mint, minp, minh);
            Assert.IsTrue(result == 1533776805);
        }
    }
}
