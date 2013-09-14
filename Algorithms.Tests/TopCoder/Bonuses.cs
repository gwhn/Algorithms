using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class Bonuses
    {
        private readonly Code.Bonuses _unit = new Code.Bonuses();

        /// <summary>
        /// {1,2,3,4,5}
        /// Returns: { 6,  13,  20,  27,  34 }
        /// The total points in the point pool is 1+2+3+4+5 = 15. Employee 1 gets 1/15 of the total pool, or 6.66667%, Employee 2 gets 13.33333%, Employee 3 gets 20% (exactly), Employee 4 gets 26.66667%, and Employee 5 gets 33.33333%. After truncating, the percentages look like: {6,13,20,26,33} Adding up all the fractional percentages, we see there is 2% in extra bonuses, which go to the top two scorers. These are the employees who received 4 and 5 points.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var points = new[] {1, 2, 3, 4, 5};
            var result = _unit.GetDivision(points);
            var expected = new[] {6, 13, 20, 27, 34};
            Assert.IsTrue(expected.Length == result.Length);
            for (var i = 0; i < result.Length; i++)
            {
                Assert.IsTrue(result[i] == expected[i]);
            }
        }

        /// <summary>
        /// {5,5,5,5,5,5}
        /// Returns: { 17,  17,  17,  17,  16,  16 }
        /// The pool of points is 30. Each employee got 1/6 of the total pool, which translates to 16.66667%. Truncating for all employees, we are left with 4% in extra bonuses. Because everyone got the same number of points, the extra 1% bonuses are assigned to the four that come first in the array.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var points = new[] {5, 5, 5, 5, 5, 5};
            var result = _unit.GetDivision(points);
            var expected = new[] {17, 17, 17, 17, 16, 16};
            Assert.IsTrue(expected.Length == result.Length);
            for (var i = 0; i < result.Length; i++)
            {
                Assert.IsTrue(result[i] == expected[i]);
            }
        }

        /// <summary>
        /// {485, 324, 263, 143, 470, 292, 304, 188, 100, 254, 296,
        ///  255, 360, 231, 311, 275,  93, 463, 115, 366, 197, 470}
        /// Returns: 
        /// { 8,  6,  4,  2,  8,  5,  5,  3,  1,  4,  5,  4,  6,  3,  5,  4,  1,  8,
        ///   1,  6,  3,  8 }
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var points = new[]
                {
                    485, 324, 263, 143, 470, 292, 304, 188, 100, 254, 296, 255, 
                    360, 231, 311, 275, 93, 463, 115, 366, 197, 470
                };
            var result = _unit.GetDivision(points);
            var expected = new[]
                {
                    8, 6, 4, 2, 8, 5, 5, 3, 1, 4, 5,
                    4, 6, 3, 5, 4, 1, 8, 1, 6, 3, 8
                };
            Assert.IsTrue(expected.Length == result.Length);
            for (var i = 0; i < result.Length; i++)
            {
                Assert.IsTrue(result[i] == expected[i]);
            }
        }
    }
}