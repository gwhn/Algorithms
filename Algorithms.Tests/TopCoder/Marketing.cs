using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class Marketing
    {
        private readonly Code.Marketing _unit = new Code.Marketing();

        /// <summary>
        /// {"1 4","2","3","0",""}
        /// Returns: 2
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var compete = new[] { "1 4", "2", "3", "0", "" };
            var result = _unit.HowMany(compete);
            Assert.IsTrue(result == 2);
        }

        /// <summary>
        /// {"1","2","0"}
        /// Returns: -1
        /// Product 0 cannot be marketed with product 1 or 2. Product 1 cannot be marketed with product 2. There is no way to achieve a viable marketing scheme. 
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var compete = new[] { "1", "2", "0" };
            var result = _unit.HowMany(compete);
            Assert.IsTrue(result == -1);
        }

        /// <summary>
        /// {"1","2","3","0","0 5","1"}
        /// Returns: 2
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var compete = new[] { "1", "2", "3", "0", "0 5", "1" };
            var result = _unit.HowMany(compete);
            Assert.IsTrue(result == 2);
        }

        /// <summary>
        /// {"","","","","","","","","","",
        ///  "","","","","","","","","","",
        ///  "","","","","","","","","",""}
        /// Returns: 1073741824
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            var compete = new[]{"","","","","","","","","","","","","","","","","","","","","","","","","","","","","",""};
            var result = _unit.HowMany(compete);
            Assert.IsTrue(result == 1073741824);
        }

        /// <summary>
        /// {"1","2","3","0","5","6","4"}
        /// Returns: -1
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            var compete = new[] { "1", "2", "3", "0", "5", "6", "4" };
            var result = _unit.HowMany(compete);
            Assert.IsTrue(result == -1);
        }
    }
}
