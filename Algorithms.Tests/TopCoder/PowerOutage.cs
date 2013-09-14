using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class PowerOutage
    {
        private readonly Code.PowerOutage _unit = new Code.PowerOutage();

        /// <summary>
        ///     {0}
        ///     {1}
        ///     {10}
        ///     Returns: 10
        ///     The simplest sewer system possible. Your technician would first check transformer 0, travel to junction 1 and check transformer 1, completing his check. This will take 10 minutes.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var from = new[] {0};
            var to = new[] {1};
            var len = new[] {10};
            int result = _unit.EstimateTimeOut(from, to, len);
            Assert.IsTrue(result == 10);
        }

        /// <summary>
        ///     {0,1,0}
        ///     {1,2,3}
        ///     {10,10,10}
        ///     Returns: 40
        ///     Starting at junction 0, if the technician travels to junction 3 first, then backtracks to 0 and travels to junction 1 and then junction 2, all four transformers can be checked in 40 minutes, which is the minimum.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var from = new[] {0, 1, 0};
            var to = new[] {1, 2, 3};
            var len = new[] {10, 10, 10};
            int result = _unit.EstimateTimeOut(from, to, len);
            Assert.IsTrue(result == 40);
        }

        /// <summary>
        ///     {0,0,0,1,4}
        ///     {1,3,4,2,5}
        ///     {10,10,100,10,5}
        ///     Returns: 165
        ///     Traveling in the order 0-1-2-1-0-3-0-4-5 results in a time of 165 minutes which is the minimum.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var from = new[] {0, 0, 0, 1, 4};
            var to = new[] {1, 3, 4, 2, 5};
            var len = new[] {10, 10, 100, 10, 5};
            int result = _unit.EstimateTimeOut(from, to, len);
            Assert.IsTrue(result == 165);
        }

        /// <summary>
        ///     {0,0,0,1,4,4,6,7,7,7,20}
        ///     {1,3,4,2,5,6,7,20,9,10,31}
        ///     {10,10,100,10,5,1,1,100,1,1,5}
        ///     Returns: 281
        ///     Visiting junctions in the order 0-3-0-1-2-1-0-4-5-4-6-7-9-7-10-7-8-11 is optimal, which takes (10+10+10+10+10+10+100+5+5+1+1+1+1+1+1+100+5) or 281 minutes.
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            var from = new[] {0, 0, 0, 1, 4, 4, 6, 7, 7, 7, 20};
            var to = new[] {1, 3, 4, 2, 5, 6, 7, 20, 9, 10, 31};
            var len = new[] {10, 10, 100, 10, 5, 1, 1, 100, 1, 1, 5};
            int result = _unit.EstimateTimeOut(from, to, len);
            Assert.IsTrue(result == 281);
        }

        /// <summary>
        ///     {0,0,0,0,0}
        ///     {1,2,3,4,5}
        ///     {100,200,300,400,500}
        ///     Returns: 2500
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            var from = new[] {0, 0, 0, 0, 0};
            var to = new[] {1, 2, 3, 4, 5};
            var len = new[] {100, 200, 300, 400, 500};
            int result = _unit.EstimateTimeOut(from, to, len);
            Assert.IsTrue(result == 2500);
        }
    }
}