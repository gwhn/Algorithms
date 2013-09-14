using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class Flush
    {
        private readonly Code.Flush _unit = new Code.Flush();

        /// <summary>
        /// {2,2,2,2}
        /// 2
        /// Returns: 1.1428571428571428
        /// Draw the first card; 
        /// you have a 1 out of 7 chance to draw the matching suit for your second card. 
        /// The expected size is thus (1/7 * 2) + (6/7 * 1) = 8/7 = 1.1428571428571428.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            int[] suits = new[] { 2, 2, 2, 2 };
            const int number = 2;
            var result = _unit.Size(suits, number);
            Assert.IsTrue(result == 1.1428571428571428D);
        }

        /// <summary>
        /// {1,4,7,10}
        /// 22
        /// Returns: 10.0
        /// You are drawing all of the cards, so your largest flush will be of size 10.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            int[] suits = new[] { 1, 4, 7, 10 };
            const int number = 22;
            var result = _unit.Size(suits, number);
                Assert.IsTrue(result == 10.0D);
        }

        /// <summary>
        /// {13, 13, 13, 13}
        /// 49
        /// Returns: 13.0
        /// If you get 12 cards of each suit, you must have drawn 48 cards, 
        /// so drawing 49, 50, 51, or 52 cards must give you a flush of size 13.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            int[] suits = new[] { 13, 13, 13, 13 };
            const int number = 49;
            var result = _unit.Size(suits, number);
            Assert.IsTrue(result == 13.0D);
        }

        /// <summary>
        /// {13, 13, 13, 13}
        /// 26
        /// Returns: 8.351195960938014
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            int[] suits = new[] { 13, 13, 13, 13 };
            const int number = 26;
            var result = _unit.Size(suits, number);
            Assert.IsTrue(result == 8.351195960938014D);
        }

        /// <summary>
        /// {13,13,13,13}
        /// 0
        /// Returns: 0.0
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            int[] suits = new[] { 13, 13, 13, 13 };
            const int number = 0;
            var result = _unit.Size(suits, number);
            Assert.IsTrue(result == 0.0D);
        }
    }
}
