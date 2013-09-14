using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class ChampernownesConstant
    {
        private readonly Code.ProjectEuler.ChampernownesConstant _unit = new Code.ProjectEuler.ChampernownesConstant();

        [TestMethod]
        public void Test1()
        {
            const int p = 6;
            var result = _unit.Solve(p);
            Assert.IsTrue(result == 210);
        }
    }
}
