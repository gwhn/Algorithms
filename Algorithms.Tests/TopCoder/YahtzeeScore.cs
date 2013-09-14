using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class YahtzeeScore
    {
        private readonly Code.YahtzeeScore _unit = new Code.YahtzeeScore();

        /// <summary>
        /// { 2, 2, 3, 5, 4 }
        /// Returns: 5
        /// The example from the text.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var toss = new[] { 2, 2, 3, 5, 4 };
            var result = _unit.MaxPoints(toss);
            Assert.IsTrue(result == 5);
        }

        /// <summary>
        /// { 6, 4, 1, 1, 3 }
        /// Returns: 6
        /// Selecting 1 as active yields 1 + 1 = 2, selecting 3 yields 3, selecting 4 yields 4 and selecting 6 yields 6, 
        /// which is the maximum number of points.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var toss = new[] { 6, 4, 1, 1, 3 };
            var result = _unit.MaxPoints(toss);
            Assert.IsTrue(result == 6);
        }

        /// <summary>
        /// { 5, 3, 5, 3, 3 }
        /// Returns: 10
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var toss = new[] { 5, 3, 5, 3, 3 };
            var result = _unit.MaxPoints(toss);
            Assert.IsTrue(result == 10);
        }
    }
}
