using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class TheSumOfLuckyNumbers
    {
        private readonly Code.TheSumOfLuckyNumbers _unit = new Code.TheSumOfLuckyNumbers();

        /// <summary>
        /// 11
        /// Returns: {4, 7 }
        /// It is simple: 11 = 4 + 7.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int n = 11;
            var result = _unit.Sum(n);
            Assert.IsTrue(result.Length == 2);
            Assert.IsTrue(result[0] == 4);
            Assert.IsTrue(result[1] == 7);
        }

        /// <summary>
        /// 12
        /// Returns: {4, 4, 4 }
        /// Now we need three summands to get 12.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int n = 12;
            var result = _unit.Sum(n);
            Assert.IsTrue(result.Length == 3);
            Assert.IsTrue(result[0] == 4);
            Assert.IsTrue(result[1] == 4);
            Assert.IsTrue(result[2] == 4);
        }

        /// <summary>
        /// 13
        /// Returns: { }
        /// And now we can not get 13 at all.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int n = 13;
            var result = _unit.Sum(n);
            Assert.IsTrue(result.Length == 0);
        }

        /// <summary>
        /// 100
        /// Returns: {4, 4, 4, 44, 44 }
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const int n = 100;
            var result = _unit.Sum(n);
            Assert.IsTrue(result.Length == 5);
            Assert.IsTrue(result[0] == 4);
            Assert.IsTrue(result[1] == 4);
            Assert.IsTrue(result[2] == 4);
            Assert.IsTrue(result[3] == 44);
            Assert.IsTrue(result[4] == 44);
        }
    }
}
