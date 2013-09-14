using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class RearrangeFurniture
    {
        private readonly Code.RearrangeFurniture _unit = new Code.RearrangeFurniture();

        /// <summary>
        /// {5, 4, 7, 3, 10}
        /// {1, 2, 0, 4, 3}
        /// Returns: 33
        /// One way to do this with the minimum effort is like so: 
        /// step 0: {0, 1, 2, 3, 4} 
        /// step 1: {0, 2, 1, 3, 4} (cost: 11) 
        /// step 2: {1, 2, 0, 3, 4} (cost: 9) 
        /// step 3: {1, 2, 0, 4, 3} (cost: 13) 
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var weights = new[] { 5, 4, 7, 3, 10 };
            var finalPositions = new[] { 1, 2, 0, 4, 3 };
            var result = _unit.LowestEffort(weights, finalPositions);
            Assert.IsTrue(result == 33);
        }

        /// <summary>
        /// {3, 6, 2, 4, 10, 3}
        /// {0, 1, 2, 3, 4, 5}
        /// Returns: 0
        /// Look at that - no work to be done! 
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var weights = new[] { 3, 6, 2, 4, 10, 3 };
            var finalPositions = new[] { 0, 1, 2, 3, 4, 5 };
            var result = _unit.LowestEffort(weights, finalPositions);
            Assert.IsTrue(result == 0);
        }

        /// <summary>
        /// {10, 3, 123, 498, 12, 13, 14, 45, 32, 67,
        ///  111, 234, 543, 2, 12, 1, 56, 67, 78, 89,
        ///  12, 90, 23, 77, 345, 543, 242, 560, 121, 232,
        ///  980, 10000, 12, 1, 6, 98, 67, 44, 21, 456,
        ///  3231, 456, 23, 14, 678, 65, 45, 23, 99, 23}
        /// {49, 48, 47, 46, 45, 44, 43, 42, 41, 40,
        ///  39, 38, 37, 36, 35, 34, 33, 32, 31, 30,
        ///  29, 28, 27, 26, 25, 24, 23, 22, 21, 20,
        ///  19, 18, 17, 16, 15, 14, 13, 12, 11, 10,
        ///  9, 8, 7, 6, 5, 4, 3, 2, 1, 0}
        /// Returns: 20597
        /// On this one, you just have to swap two elements into place 25 times. 
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var weights = new[]
                {
                    10, 3, 123, 498, 12, 13, 14, 45, 32, 67, 111, 234, 543, 2, 12, 1, 56, 67, 78, 89, 12, 90, 23, 77, 345,
                    543, 242, 560, 121, 232, 980, 10000, 12, 1, 6, 98, 67, 44, 21, 456, 3231, 456, 23, 14, 678, 65, 45,
                    23, 99, 23
                };
            var finalPositions = new[]
                {
                    49, 48, 47, 46, 45, 44, 43, 42, 41, 40, 39, 38, 37, 36, 35, 34, 33, 32, 31, 30, 29, 28, 27, 26, 25, 24,
                    23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0
                };
            var result = _unit.LowestEffort(weights, finalPositions);
            Assert.IsTrue(result == 20597);
        }
    }
}
