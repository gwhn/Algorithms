using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class WidgetRepairs
    {
        private readonly Code.WidgetRepairs _unit = new Code.WidgetRepairs();

        /// <summary>
        /// { 10, 0, 0, 4, 20 }
        /// 8
        /// Returns: 6
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            int[] arrivals = new[] { 10, 0, 0, 4, 20 };
            const int numPerDay = 8;
            var result = _unit.Days(arrivals, numPerDay);
            Assert.IsTrue(result == 6);
        }

        /// <summary>
        /// { 0, 0, 0 }
        /// 10
        /// Returns: 0
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            int[] arrivals = new[] { 0, 0, 0 };
            const int numPerDay = 10;
            var result = _unit.Days(arrivals, numPerDay);
            Assert.IsTrue(result == 0);
        }

        /// <summary>
        /// { 100, 100 }
        /// 10
        /// Returns: 20
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            int[] arrivals = new[] { 100, 100 };
            const int numPerDay = 10;
            var result = _unit.Days(arrivals, numPerDay);
            Assert.IsTrue(result == 20);
        }

        /// <summary>
        /// { 27, 0, 0, 0, 0, 9 }
        /// 9
        /// Returns: 4
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            int[] arrivals = new[] { 27, 0, 0, 0, 0, 9 };
            const int numPerDay = 9;
            var result = _unit.Days(arrivals, numPerDay);
            Assert.IsTrue(result == 4);
        }

        /// <summary>
        /// { 6, 5, 4, 3, 2, 1, 0, 0, 1, 2, 3, 4, 5, 6 }
        /// 3
        /// Returns: 15
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            int[] arrivals = new[] { 6, 5, 4, 3, 2, 1, 0, 0, 1, 2, 3, 4, 5, 6 };
            const int numPerDay = 3;
            var result = _unit.Days(arrivals, numPerDay);
            Assert.IsTrue(result == 15);
        }
    }
}
