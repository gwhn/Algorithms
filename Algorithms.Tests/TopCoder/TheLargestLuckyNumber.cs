using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class TheLargestLuckyNumber
    {
        private readonly Code.TheLargestLuckyNumber _unit = new Code.TheLargestLuckyNumber();

        /// <summary>
        /// 100
        /// Returns: 77
        /// 77 is the largest lucky number that is not greater than 100.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int n = 100;
            var result = _unit.Find(n);
            Assert.IsTrue(result == 77);
        }

        /// <summary>
        /// 75
        /// Returns: 74
        /// 74 is the lucky number that immediately precedes 77.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int n = 75;
            var result = _unit.Find(n);
            Assert.IsTrue(result == 74);
        }

        /// <summary>
        /// 5
        /// Returns: 4
        /// The smallest lucky number is 4.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int n = 5;
            var result = _unit.Find(n);
            Assert.IsTrue(result == 4);
        }

        /// <summary>
        /// 474747
        /// Returns: 474747
        /// n is a lucky number.
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const int n = 474747;
            var result = _unit.Find(n);
            Assert.IsTrue(result == 474747);
        }
    }
}
