using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class TravellingPurchasingMan
    {
        private readonly Code.TravellingPurchasingMan _unit = new Code.TravellingPurchasingMan();

        /// <summary>
        /// 3
        /// {"1 10 10" , "1 55 31", "10 50 100" }
        /// {"1 2 10"}
        /// Returns: 1
        /// It is not possible to make more than one purchase: 
        /// •If you decide to make the purchase at store 2: 
        ///     You need to wait 10 seconds until it opens. 
        ///     Then wait until time = 110 seconds for the purchase to finish. 
        ///     At 110 seconds, all the other stores will be closed.
        /// •If you instead decide to make the purchase at store 1: 
        ///     You first need travel through the road and arrive store 1 at time = 10. 
        ///     The purchase finishes at time = 41. 
        ///     After you travel back to store 2, the time will be 51 seconds and store 2 will be closed.
        /// •There is no way to reach store 0 when store 2 is the starting point.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int n = 3;
            var interestingStores = new[] { "1 10 10", "1 55 31", "10 50 100" };
            var roads = new[] { "1 2 10" };
            var result = _unit.MaxStores(n, interestingStores, roads);
            Assert.IsTrue(result == 1);
        }

        /// <summary>
        /// 3
        /// {"1 10 10" , "1 55 30", "10 50 100" }
        /// {"1 2 10"}
        /// Returns: 2
        /// This time we can travel to store 1, make the purchase and return to store 2 exactly at time = 50 to make two purchases in total.  
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int n = 3;
            var interestingStores = new[] { "1 10 10", "1 55 30", "10 50 100" };
            var roads = new[] { "1 2 10" };
            var result = _unit.MaxStores(n, interestingStores, roads);
            Assert.IsTrue(result == 2);
        }

        /// <summary>
        /// 5
        /// {"0 1000 17"}
        /// {"2 3 400", "4 1 500", "4 3 300", "1 0 700", "0 2 400"}
        /// Returns: 0
        /// It is not possible to reach store 0 before it closes.  
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int n = 5;
            var interestingStores = new[] { "0 1000 17" };
            var roads = new[] { "2 3 400", "4 1 500", "4 3 300", "1 0 700", "0 2 400" };
            var result = _unit.MaxStores(n, interestingStores, roads);
            Assert.IsTrue(result == 1);
        }
    }
}
