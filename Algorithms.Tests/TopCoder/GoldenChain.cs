using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class GoldenChain
    {
        private readonly Code.GoldenChain _unit = new Code.GoldenChain();

        /// <summary>
        /// {3,3,3,3}
        /// Returns: 3
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            int[] sections = new int[] { 3, 3, 3, 3 };
            var result = _unit.MinCuts(sections);
            Assert.IsTrue(result == 3);
        }

        /// <summary>
        /// {2000000000}
        /// Returns: 1
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            int[] sections = new int[] { 2000000000 };
            var result = _unit.MinCuts(sections);
            Assert.IsTrue(result == 1);
        }

        /// <summary>
        /// {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,
        /// 21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,
        /// 38,39,40,41,42,43,44,45,46,47,48,49,50}
        /// Returns: 42
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            int[] sections = new int[]
                {
                    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28,
                    29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50
                };
            var result = _unit.MinCuts(sections);
            Assert.IsTrue(result == 42);
        }

        /// <summary>
        /// {20000000,20000000,2000000000}
        /// Returns: 3
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            int[] sections = new int[] { 20000000, 20000000, 2000000000 };
            var result = _unit.MinCuts(sections);
            Assert.IsTrue(result == 3);
        }

        /// <summary>
        /// {10,10,10,10,10,1,1,1,1,1}
        /// Returns: 5
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            int[] sections = new int[] { 10, 10, 10, 10, 10, 1, 1, 1, 1, 1 };
            var result = _unit.MinCuts(sections);
            Assert.IsTrue(result == 5);
        }

        /// <summary>
        /// {1,10}
        /// Returns: 1
        /// </summary>
        [TestMethod]
        public void Test6()
        {
            int[] sections = new int[] { 1, 10 };
            var result = _unit.MinCuts(sections);
            Assert.IsTrue(result == 1);
        }
    }
}
