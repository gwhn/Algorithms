using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class Boxing
    {
        private readonly Code.Boxing _unit = new Code.Boxing();

        /// <summary>
        /// {1,2,3,4,5,6}
        /// {1,2,3,4,5,6,7}
        /// {1,2,3,4,5,6}
        /// {0,1,2}
        /// {1,2,3,4,5,6,7,8}
        /// Returns: 6
        /// This match had a fast start, with 6 punches credited in the first 6 milliseconds of the match! 
        /// One way to choose 6 disjoint intervals is to choose [1,1], [2,2], [3,3], [4,4], [5,5], [6,6] 
        /// each of which contains button presses from judges a, b, and c. 
        /// There are three button presses in the time interval from 7 through 8, 
        /// but only from two different judges so no additional credit can be given.  
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var a = new[] { 1, 2, 3, 4, 5, 6 };
            var b = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var c = new[] { 1, 2, 3, 4, 5, 6 };
            var d = new[] { 0, 1, 2 };
            var e = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var result = _unit.MaxCredit(a, b, c, d, e);
            Assert.IsTrue(result == 6);
        }

        /// <summary>
        /// {100,200,300,1200,6000}
        /// {}
        /// {900,902,1200,4000,5000,6001}
        /// {0,2000,6002}
        /// {1,2,3,4,5,6,7,8}
        /// Returns: 3
        /// One way to form three intervals is [0,1000], [1001,2000], [6000,6002]  
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var a = new[] { 100, 200, 300, 1200, 6000 };
            var b = new int[] {};
            var c = new[] { 900, 902, 1200, 4000, 5000, 6001 };
            var d = new[] { 0, 2000, 6002 };
            var e = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var result = _unit.MaxCredit(a, b, c, d, e);
            Assert.IsTrue(result == 3);
        }

        /// <summary>
        /// {5000,6500}
        /// {6000}
        /// {6500}
        /// {6000}
        /// {0,5800,6000}
        /// Returns: 1
        /// Any interval that doesn't include 6000 will not have enough button presses, 
        /// so we can form only one disjoint interval with credit for a punch.  
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var a = new[] { 5000, 6500 };
            var b = new[] { 6000 };
            var c = new[] { 6500 };
            var d = new[] { 6000 };
            var e = new[] { 0, 5800, 6000 };
            var result = _unit.MaxCredit(a, b, c, d, e);
            Assert.IsTrue(result == 1);
        }
    }
}
