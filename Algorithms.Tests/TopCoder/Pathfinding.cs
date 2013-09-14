using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class Pathfinding
    {
        private readonly Code.Pathfinding _unit = new Code.Pathfinding();

        /// <summary>
        /// 0
        /// -4
        /// Returns: 8
        /// A possible path from (0,0) to (0,-4) is through the points (1,0), (1,-3), (-1,-3) and (-1,-4).
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int x = 0;
            const int y = -4;
            var result = _unit.GetDirections(x, y);
            Assert.IsTrue(result == 8);
        }

        /// <summary>
        /// 5
        /// -4
        /// Returns: 9
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int x = 5;
            const int y = -4;
            var result = _unit.GetDirections(x, y);
            Assert.IsTrue(result == 9);
        }

        /// <summary>
        /// 5
        /// 4
        /// Returns: 9
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int x = 5;
            const int y = 4;
            var result = _unit.GetDirections(x, y);
            Assert.IsTrue(result == 9);
        }

        /// <summary>
        /// -1
        /// -4
        /// Returns: 7
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const int x = -1;
            const int y = -4;
            var result = _unit.GetDirections(x, y);
            Assert.IsTrue(result == 7);
        }

        /// <summary>
        /// 0
        /// 0
        /// Returns: 0
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const int x = 0;
            const int y = 0;
            var result = _unit.GetDirections(x, y);
            Assert.IsTrue(result == 0);
        }
    }
}
