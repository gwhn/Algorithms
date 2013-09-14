using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class TruncatablePrimes
    {
        private readonly Code.ProjectEuler.TruncatablePrimes _unit = new Code.ProjectEuler.TruncatablePrimes();

        [TestMethod]
        public void Test1()
        {
            var result = _unit.Solve();
            Assert.IsTrue(result == 748317);
        }
    }
}
