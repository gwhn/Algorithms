using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class BridgeCrossing
    {
        private readonly Code.BridgeCrossing _unit = new Code.BridgeCrossing();

        /// <summary>
        /// { 1, 2, 5, 10 }
        /// Returns: 17
        /// The example from the text.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var times = new[] { 1, 2, 5, 10 };
            var result = _unit.MinTime(times);
            Assert.IsTrue(result == 17);
        }

        /// <summary>
        /// { 1, 2, 3, 4, 5 }
        /// Returns: 16
        /// One solution is: 
        ///     1 and 2 cross together (2min), 
        ///     1 goes back (1min), 
        ///     4 and 5 cross together (5min), 
        ///     2 goes back (2min), 
        ///     1 and 3 cross together (3min), 
        ///     1 goes back (1min), 
        ///     1 and 2 cross together (2min). 
        /// This yields a total of 2 + 1 + 5 + 2 + 3 + 1 + 2 = 16 minutes spent.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var times = new[] { 1, 2, 3, 4, 5 };
            var result = _unit.MinTime(times);
            Assert.IsTrue(result == 16);
        }

        /// <summary>
        /// { 100 }
        /// Returns: 100
        /// Only one person crosses the bridge once.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var times = new[]{ 100 };
            var result = _unit.MinTime(times);
            Assert.IsTrue(result == 100);
        }

        /// <summary>
        /// { 1, 2, 3, 50, 99, 100 }
        /// Returns: 162
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            var times = new[] { 1, 2, 3, 50, 99, 100 };
            var result = _unit.MinTime(times);
            Assert.IsTrue(result == 162);
        }
    }
}
