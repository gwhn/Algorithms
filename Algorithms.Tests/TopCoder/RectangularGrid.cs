using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class RectangularGrid
    {
        private readonly Code.RectangularGrid _unit = new Code.RectangularGrid();

        /// <summary>
        /// 3
        /// 3
        /// Returns: 22
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int width = 3;
            const int height = 3;
            var result = _unit.CountRectangles(width, height);
            Assert.IsTrue(result == 22);
        }

        /// <summary>
        /// 5
        /// 2
        /// Returns: 31
        ///  __ __ __ __ __
        /// |__|__|__|__|__|
        /// |__|__|__|__|__|
        /// In this grid, there is one 2x5 rectangle, 2 2x4 rectangles, 2 1x5 rectangles, 3 2x3 rectangles, 
        /// 4 1x4 rectangles, 6 1x3 rectangles and 13 1x2 rectangles. 
        /// Thus there is a total of 1 + 2 + 2 + 3 + 4 + 6 + 13 = 31 rectangles.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int width = 5;
            const int height = 2;
            var result = _unit.CountRectangles(width, height);
            Assert.IsTrue(result == 31);
        }

        /// <summary>
        /// 10
        /// 10
        /// Returns: 2640
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int width = 10;
            const int height = 10;
            var result = _unit.CountRectangles(width, height);
            Assert.IsTrue(result == 2640);
        }

        /// <summary>
        /// Examples
        /// 1
        /// 1
        /// Returns: 0
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const int width = 1;
            const int height = 1;
            var result = _unit.CountRectangles(width, height);
            Assert.IsTrue(result == 0);
        }

        /// <summary>
        /// 592
        /// 964
        /// Returns: 81508708664
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const int width = 592;
            const int height = 964;
            var result = _unit.CountRectangles(width, height);
            Assert.IsTrue(result == 81508708664);
        }
    }
}
