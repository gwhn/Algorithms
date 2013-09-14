using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class TheLuckyNumbers
    {
        private readonly Code.TheLuckyNumbers _unit = new Code.TheLuckyNumbers();

        /// <summary>
        /// 1
        /// 10
        /// Returns: 2
        /// There are only two lucky numbers among the first ten positive integers.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int a = 1;
            const int b = 10;
            var result = _unit.Count(a, b);
            Assert.IsTrue(result == 2);
        }

        /// <summary>
        /// 11
        /// 20
        /// Returns: 0
        /// But there are none among the next ten.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int a = 11;
            const int b = 20;
            var result = _unit.Count(a, b);
            Assert.IsTrue(result == 0);
        }

        /// <summary>
        /// 74
        /// 77
        /// Returns: 2
        /// These two numbers are lucky. There are no additional lucky numbers between them.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int a = 74;
            const int b = 77;
            var result = _unit.Count(a, b);
            Assert.IsTrue(result == 2);
        }

        /// <summary>
        /// 1000000
        /// 5000000
        /// Returns: 64
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const int a = 1000000;
            const int b = 5000000;
            var result = _unit.Count(a, b);
            Assert.IsTrue(result == 64);
        }
    }
}
