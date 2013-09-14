using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class PiecewiseLinearFunction
    {
        private readonly Code.PiecewiseLinearFunction _unit = new Code.PiecewiseLinearFunction();

        /// <summary>
        /// {3, 2}
        /// Returns: 1
        /// The graph of this function is a line segment between (1, 3) and (2, 2). 
        /// For any y such that 2 ≤ y ≤ 3 the equation F(x)=y has 1 solution, and for any other y it has 0 solutions. 
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var Y = new[] { 3, 2 };
            var result = _unit.MaximumSolutions(Y);
            Assert.IsTrue(result == 1);
        }

        /// <summary>
        /// {4, 4}
        /// Returns: -1
        /// The function's plot is a horizontal line segment between points (1, 4) and (2, 4). 
        /// For y=4, F(x)=y has infinitely many solutions. 
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var Y = new[] { 4, 4 };
            var result = _unit.MaximumSolutions(Y);
            Assert.IsTrue(result == -1);
        }

        /// <summary>
        /// {1, 4, -1, 2}
        /// Returns: 3
        /// This is the example from the problem statement. 
        /// Three solutions are obtained for any value of y between 1 and 2, inclusive: 
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var Y = new[] { 1, 4, -1, 2 };
            var result = _unit.MaximumSolutions(Y);
            Assert.IsTrue(result == 3);
        }

        /// <summary>
        /// {2, 1, 2, 1, 3, 2, 3, 2}
        /// Returns: 5
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            var Y = new[] { 2, 1, 2, 1, 3, 2, 3, 2 };
            var result = _unit.MaximumSolutions(Y);
            Assert.IsTrue(result == 5);
        }

        /// <summary>
        /// {125612666, -991004227, 0, 6, 88023, -1000000000, 1000000000, -1000000000, 1000000000}
        /// Returns: 6
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            var Y = new[] { 125612666, -991004227, 0, 6, 88023, -1000000000, 1000000000, -1000000000, 1000000000 };
            var result = _unit.MaximumSolutions(Y);
            Assert.IsTrue(result == 6);
        }
    }
}
