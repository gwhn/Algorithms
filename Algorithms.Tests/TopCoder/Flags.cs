using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class Flags
    {
        private readonly Code.Flags _unit = new Code.Flags();

        /// <summary>
        /// "10"
        /// {"0","1 2","1 2"}
        /// Returns: 3
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const string numFlags = "10";
            var forbidden = new[] { "0", "1 2", "1 2" };
            var result = _unit.NumStripes(numFlags, forbidden);
            Assert.IsTrue(result == 3);
        }

        /// <summary>
        /// "100"
        /// {"0","1","2"}
        /// Returns: 6
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const string numFlags = "100";
            var forbidden = new[] { "0", "1", "2" };
            var result = _unit.NumStripes(numFlags, forbidden);
            Assert.IsTrue(result == 6);
        }

        /// <summary>
        /// "100000000000000000"
        /// {"0","1"}
        /// Returns: 50000000000000000
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const string numFlags = "100000000000000000";
            var forbidden = new[] { "0", "1" };
            var result = _unit.NumStripes(numFlags, forbidden);
            Assert.IsTrue(result == 50000000000000000);
        }

        /// <summary>
        /// "10000000000000000"
        /// {"0 1", "0 1", "2 3 4", "2 3 4", "2 3 4"}
        /// Returns: 40
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const string numFlags = "10000000000000000";
            var forbidden = new[] { "0 1", "0 1", "2 3 4", "2 3 4", "2 3 4" };
            var result = _unit.NumStripes(numFlags, forbidden);
            Assert.IsTrue(result == 40);
        }

        /// <summary>
        /// "10000000000000000"
        /// {"0 1 2 3 4 5 6 7 8 9", "0 1 3 4 5 6 7 8 9", "0 2 3 4 5 6 7 8 9", "0 1 2 3 4 5 6 7 8 9", 
        /// "0 1 2 3 4 5 6 7 8 9", "0 1 2 3 4 5 6 7 8 9", "0 1 2 3 4 5 6 7 8 9", 
        /// "0 1 2 3 4 5 6 7 8 9", "0 1 2 3 4 5 6 7 8 9", "0 1 2 3 4 5 6 7 8 9"}
        /// Returns: 4999999999999996
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const string numFlags = "10000000000000000";
            var forbidden = new[]
                {
                    "0 1 2 3 4 5 6 7 8 9", "0 1 3 4 5 6 7 8 9", "0 2 3 4 5 6 7 8 9", "0 1 2 3 4 5 6 7 8 9",
                    "0 1 2 3 4 5 6 7 8 9", "0 1 2 3 4 5 6 7 8 9", "0 1 2 3 4 5 6 7 8 9", "0 1 2 3 4 5 6 7 8 9",
                    "0 1 2 3 4 5 6 7 8 9", "0 1 2 3 4 5 6 7 8 9"
                };
            var result = _unit.NumStripes(numFlags, forbidden);
            Assert.IsTrue(result == 4999999999999996);
        }

        /// <summary>
        /// "5"
        /// {"0","1","2","3","4","5"}
        /// Returns: 1
        /// </summary>
        [TestMethod]
        public void Test6()
        {
            const string numFlags = "5";
            string[] forbidden = new[] { "0", "1", "2", "3", "4", "5" };
            var result = _unit.NumStripes(numFlags, forbidden);
            Assert.IsTrue(result == 1);
        }
    }
}
