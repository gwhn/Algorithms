using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class Dragons
    {
        private readonly Code.Dragons _unit = new Code.Dragons();

        /// <summary>
        /// {0, 0, 4, 0, 0, 0}
        /// 2
        /// Returns: "1"
        /// See the explanation above
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var initialFood = new[] { 0, 0, 4, 0, 0, 0 };
            const int rounds = 2;
            var result = _unit.Snaug(initialFood, rounds);
            Assert.IsTrue(result == "1");
        }

        /// <summary>
        /// {0, 0, 4, 0, 0, 0}
        /// 3
        /// Returns: "1/2"
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var initialFood = new[] { 0, 0, 4, 0, 0, 0 };
            const int rounds = 3;
            var result = _unit.Snaug(initialFood, rounds);
            Assert.IsTrue(result == "1/2");
        }

        /// <summary>
        /// {1000, 1000, 1000, 1000, 1000, 1000}
        /// 45
        /// Returns: "1000"
        /// When everybody has the same amount of food, they continue to have the same amount of food after each round
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var initialFood = new[] { 1000, 1000, 1000, 1000, 1000, 1000 };
            const int rounds = 45;
            var result = _unit.Snaug(initialFood, rounds);
            Assert.IsTrue(result == "1000");
        }

        /// <summary>
        /// {1, 2, 3, 4, 5, 6}
        /// 45
        /// Returns: "7/2"
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            var initialFood = new []{ 1, 2, 3, 4, 5, 6 };
            const int rounds = 45;
            var result = _unit.Snaug(initialFood, rounds);
            Assert.IsTrue(result == "7/2");
        }
    }
}
