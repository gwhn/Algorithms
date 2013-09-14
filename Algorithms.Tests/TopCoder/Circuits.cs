using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class Circuits
    {
        private readonly Code.Circuits _unit = new Code.Circuits();

        /// <summary>
        /// {"1 2","2",""}
        /// {"5 3","7",""}
        /// Returns: 12
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var connects = new[] { "1 2", "2", "" };
            var costs = new[] { "5 3", "7", "" };
            var result = _unit.HowLong(connects, costs);
            Assert.IsTrue(result == 12);
        }

        /// <summary>
        /// {"1 2 3 4 5","2 3 4 5","3 4 5","4 5","5",""}
        /// {"2 2 2 2 2","2 2 2 2","2 2 2","2 2","2",""}
        /// Returns: 10
        /// The longest path goes from 0-1-2-3-4-5 for a cost of 10. 
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var connects = new[] { "1 2 3 4 5", "2 3 4 5", "3 4 5", "4 5", "5", "" };
            var costs = new[] { "2 2 2 2 2", "2 2 2 2", "2 2 2", "2 2", "2", "" };
            var result = _unit.HowLong(connects, costs);
            Assert.IsTrue(result == 10);
        }

        /// <summary>
        /// {"1","2","3","","5","6","7",""}
        /// {"2","2","2","","3","3","3",""}
        /// Returns: 9
        /// The 0-1-2-3 path costs 6 whereas the 4-5-6-7 path costs 9 
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var connects = new[] { "1", "2", "3", "", "5", "6", "7", "" };
            var costs = new[] { "2", "2", "2", "", "3", "3", "3", "" };
            var result = _unit.HowLong(connects, costs);
            Assert.IsTrue(result == 9);
        }

        /// <summary>
        /// {"","2 3 5","4 5","5 6","7","7 8","8 9","10","10 11 12","11","12","12",""}
        /// {"","3 2 9","2 4","6 9","3","1 2","1 2","5","5 6 9","2","5","3",""}
        /// Returns: 22
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            var connects = new[] { "", "2 3 5", "4 5", "5 6", "7", "7 8", "8 9", "10", "10 11 12", "11", "12", "12", "" };
            var costs = new[] { "", "3 2 9", "2 4", "6 9", "3", "1 2", "1 2", "5", "5 6 9", "2", "5", "3", "" };
            var result = _unit.HowLong(connects, costs);
            Assert.IsTrue(result == 22);
        }

        /// <summary>
        /// {"","2 3","3 4 5","4 6","5 6","7","5 7",""}
        /// {"","30 50","19 6 40","12 10","35 23","8","11 20",""}
        /// Returns: 105
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            var connects = new[] { "", "2 3", "3 4 5", "4 6", "5 6", "7", "5 7", "" };
            var costs = new[] { "", "30 50", "19 6 40", "12 10", "35 23", "8", "11 20", "" };
            var result = _unit.HowLong(connects, costs);
            Assert.IsTrue(result == 105);
        }
    }
}
