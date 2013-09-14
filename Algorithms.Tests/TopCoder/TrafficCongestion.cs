using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class TrafficCongestion
    {
        private readonly Code.TrafficCongestion _unit = new Code.TrafficCongestion();

        /// <summary>
        /// 1
        /// Returns: 1
        /// In this case, one car can visit all the cities.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int treeHeight = 1;
            var result = _unit.TheMinCars(treeHeight);
            Assert.IsTrue(result == 1);
        }

        /// <summary>
        /// 2
        /// Returns: 3
        /// Here is one way to visit all cities exactly once by three cars:
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int treeHeight = 2;
            var result = _unit.TheMinCars(treeHeight);
            Assert.IsTrue(result == 3);
        }

        /// <summary>
        /// 3
        /// Returns: 5
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int treeHeight = 3;
            var result = _unit.TheMinCars(treeHeight);
            Assert.IsTrue(result == 5);
        }

        /// <summary>
        /// 585858
        /// Returns: 548973404
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const int treeHeight = 585858;
            var result = _unit.TheMinCars(treeHeight);
            Assert.IsTrue(result == 548973404);
        }
    }
}
