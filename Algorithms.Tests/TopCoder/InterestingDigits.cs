using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class InterestingDigits
    {
        private readonly Code.InterestingDigits _unit = new Code.InterestingDigits();

        /// <summary>
        /// 10
        /// Returns: { 3,  9 }
        /// All other candidate digits fail for base=10. 
        /// For example, 2 and 5 both fail on 100, for which 1+0+0=1. 
        /// Similarly, 4 and 8 both fail on 216, for which 2+1+6=9, 
        /// and 6 and 7 both fail for 126, for which 1+2+6=9.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int @base = 10;
            var result = _unit.Digits(@base);
            Assert.IsTrue(result.Length == 2);
            Assert.IsTrue(result[0] == 3);
            Assert.IsTrue(result[1] == 9);
        }

        /// <summary>
        /// 3
        /// Returns: { 2 }
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int @base = 3;
            var result = _unit.Digits(@base);
            Assert.IsTrue(result.Length == 1);
            Assert.IsTrue(result[0] == 2);
        }

        /// <summary>
        /// 9
        /// Returns: { 2,  4,  8 }
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int @base = 9;
            var result = _unit.Digits(@base);
            Assert.IsTrue(result.Length == 3);
            Assert.IsTrue(result[0] == 2);
            Assert.IsTrue(result[1] == 4);
            Assert.IsTrue(result[2] == 8);
        }

        /// <summary>
        /// 26
        /// Returns: { 5,  25 }
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const int @base = 26;
            var result = _unit.Digits(@base);
            Assert.IsTrue(result.Length == 2);
            Assert.IsTrue(result[0] == 5);
            Assert.IsTrue(result[1] == 25);
        }

        /// <summary>
        /// 30
        /// Returns: { 29 }
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const int @base = 30;
            var result = _unit.Digits(@base);
            Assert.IsTrue(result.Length == 1);
            Assert.IsTrue(result[0] == 29);
        }
    }
}
