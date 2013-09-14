using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class Archery
    {
        private readonly Code.Archery _unit = new Code.Archery();

        /// <summary>
        /// 1
        /// {10, 0}
        /// Returns: 2.5
        /// You score 10 if you hit the central circle, and 0 otherwise. 
        /// The area of the central circle is 0.25 of the total target area.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int N = 1;
            var ringPoints = new[] { 10, 0 };
            var result = _unit.ExpectedPoints(N, ringPoints);
            Assert.IsTrue(result >= 2.5D - 1e-9);
            Assert.IsTrue(result <= 2.5D + 1e-9);
        }

        /// <summary>
        /// 3
        /// {1, 1, 1, 1}
        /// Returns: 1.0
        /// Regardless of what part of the target you hit, you get 1 point.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int N = 3;
            var ringPoints = new[] { 1, 1, 1, 1 };
            var result = _unit.ExpectedPoints(N, ringPoints);
            Assert.IsTrue(result >= 1.0D - 1e-9);
            Assert.IsTrue(result <= 1.0D + 1e-9);
        }

        /// <summary>
        /// 4
        /// {100, 0, 100, 0, 100}
        /// Returns: 60.0
        /// Only even rings of the target give you points.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int N = 4;
            var ringPoints = new[] { 100, 0, 100, 0, 100 };
            var result = _unit.ExpectedPoints(N, ringPoints);
            Assert.IsTrue(result >= 60.0D - 1e-9);
            Assert.IsTrue(result <= 60.0D + 1e-9);
        }

        /// <summary>
        /// 9
        /// {69, 50, 79, 16, 52, 71, 17, 96, 56, 32}
        /// Returns: 51.96
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const int N = 9;
            var ringPoints = new[] { 69, 50, 79, 16, 52, 71, 17, 96, 56, 32 };
            var result = _unit.ExpectedPoints(N, ringPoints);
            Assert.IsTrue(result >= 51.96D - 1e-9);
            Assert.IsTrue(result <= 51.96D + 1e-9);
        }
    }
}
