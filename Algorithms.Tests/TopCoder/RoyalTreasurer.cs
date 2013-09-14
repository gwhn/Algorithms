using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class RoyalTreasurer
    {
        private readonly Code.RoyalTreasurer _unit = new Code.RoyalTreasurer();

        /// <summary>
        /// {1,1,3}
        /// {10,30,20}
        /// Returns: 80
        /// If you move the number 3 to the beginning of A, you get the minimal possible sum.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var A = new[] { 1, 1, 3 };
            var B = new[] { 10, 30, 20 };
            var result = _unit.MinimalArrangement(A, B);
            Assert.IsTrue(result == 80);
        }

        /// <summary>
        /// {1,1,1,6,0}
        /// {2,7,8,3,1}
        /// Returns: 18
        /// The best option would be to rearrange the numbers in A this way: {1,1,0,1,6}.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var A = new[] { 1, 1, 1, 6, 0 };
            var B = new[] { 2, 7, 8, 3, 1 };
            var result = _unit.MinimalArrangement(A, B);
            Assert.IsTrue(result == 18);
        }

        /// <summary>
        /// {5,15,100,31,39,0,0,3,26}
        /// {11,12,13,2,3,4,5,9,1}
        /// Returns: 528
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var A = new[] { 5, 15, 100, 31, 39, 0, 0, 3, 26 };
            var B = new[] { 11, 12, 13, 2, 3, 4, 5, 9, 1 };
            var result = _unit.MinimalArrangement(A, B);
            Assert.IsTrue(result == 528);
        }
    }
}
