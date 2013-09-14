using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class FormatAmt
    {
        private readonly Code.FormatAmt _unit = new Code.FormatAmt();

        /// <summary>
        /// 123456
        /// 0
        /// Returns: "$123,456.00"
        /// Note that there is no space between the $ and the first digit.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int dollars = 123456;
            const int cents = 0;
            var result = _unit.Amount(dollars, cents);
            Assert.IsTrue(result == "$123,456.00");
        }

        /// <summary>
        /// 49734321
        /// 9
        /// Returns: "$49,734,321.09"
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int dollars = 49734321;
            const int cents = 9;
            var result = _unit.Amount(dollars, cents);
            Assert.IsTrue(result == "$49,734,321.09");
        }

        /// <summary>
        /// 0
        /// 99
        /// Returns: "$0.99"
        /// Note the leading 0.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int dollars = 0;
            const int cents = 99;
            var result = _unit.Amount(dollars, cents);
            Assert.IsTrue(result == "$0.99");
        }

        /// <summary>
        /// 249
        /// 30
        /// Returns: "$249.30"
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const int dollars = 249;
            const int cents = 30;
            var result = _unit.Amount(dollars, cents);
            Assert.IsTrue(result == "$249.30");
        }

        /// <summary>
        /// 1000
        /// 1
        /// Returns: "$1,000.01"
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const int dollars = 1000;
            const int cents = 1;
            var result = _unit.Amount(dollars, cents);
            Assert.IsTrue(result == "$1,000.01");
        }
    }
}
