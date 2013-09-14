using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class CoinSums
    {
        private readonly Code.ProjectEuler.CoinSums _unit = new Code.ProjectEuler.CoinSums();

        [TestMethod]
        public void Test1()
        {
            const int target = 200;
            var coins = new[] {1, 2, 5, 10, 20, 50, 100, 200};
            var result = _unit.Solve(target, coins);
            Assert.IsTrue(result == 73682);
        }
    }
}
