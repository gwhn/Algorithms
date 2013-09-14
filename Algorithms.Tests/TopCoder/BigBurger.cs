using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class BigBurger
    {
        private readonly Code.BigBurger _unit = new Code.BigBurger();

        /// <summary>
        /// {3,3,9}
        /// {2,15,14}
        /// Returns: 11
        /// Two customers arrive at time 3. 
        /// The first one waits 0 time, orders, and is served after 2 minutes, leaving at time 5. 
        /// The second one then orders and is served at time 20. 
        /// Meanwhile a customer arrives at time 9 and waits until the second customer leaves. 
        /// This last customer then orders at time 20, and is served and leaves at time 20+14 = 34. 
        /// The first customer waited 0 minutes, the second waited 2 minutes (from time 3 to time 5), 
        /// and the last customer waited 11 minutes (from time 9 to time 20).
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            int[] arrival = new int[] { 3, 3, 9 };
            int[] service = new int[] { 2, 15, 14 };
            var result = _unit.MaxWait(arrival, service);
            Assert.IsTrue(result == 11);
        }

        /// <summary>
        /// {182}
        /// {11}
        /// Returns: 0
        /// The first customer never needs to wait.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            int[] arrival = new int[] { 182 };
            int[] service = new int[] { 11 };
            var result = _unit.MaxWait(arrival, service);
            Assert.IsTrue(result == 0);
        }

        /// <summary>
        /// {2,10,11}
        /// {3,4,3}
        /// Returns: 3
        /// The third customer needs to wait from time 11 to time 14. Neither of the other customers needs to wait at all.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            int[] arrival = new int[] { 2, 10, 11 };
            int[] service = new int[] { 3, 4, 3 };
            var result = _unit.MaxWait(arrival, service);
            Assert.IsTrue(result == 3);
        }

        /// <summary>
        /// {2,10,12}
        /// {15,1,15}
        /// Returns: 7
        /// The second customer waits the longest.
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            int[] arrival = new int[] { 2, 10, 12 };
            int[] service = new int[] { 15, 1, 15 };
            var result = _unit.MaxWait(arrival, service);
            Assert.IsTrue(result == 7);
        }
    }
}
