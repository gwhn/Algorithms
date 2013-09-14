using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class PrefixCode
    {
        private readonly Code.PrefixCode _unit = new Code.PrefixCode();

        /// <summary>
        /// {"trivial"}
        /// Returns: "Yes"
        /// As there is only one word, no word can be the prefix of another, so this is a trivial example of a prefix code.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var words = new[] { "trivial" };
            var result = _unit.IsOne(words);
            Assert.IsTrue(result == "Yes");
        }

        /// <summary>
        /// {"10001", "011", "100", "001", "10"}
        /// Returns: "No, 2"
        /// "100" (at index 2) and "10" (at index 4) are both a prefix of "10001" and "10" is also a prefix of "100", 
        /// therefore it is no prefix code. "100" is the prefix with the lowest index.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var words = new[] { "10001", "011", "100", "001", "10" };
            var result = _unit.IsOne(words);
            Assert.IsTrue(result == "No, 2");
        }

        /// <summary>
        /// {"no", "nosy", "neighbors", "needed"}
        /// Returns: "No, 0"
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var words = new[] { "no", "nosy", "neighbors", "needed" };
            var result = _unit.IsOne(words);
            Assert.IsTrue(result == "No, 0");
        }

        /// <summary>
        /// {"1010", "11", "100", "0", "1011"}
        /// Returns: "Yes"
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            var words = new[] { "1010", "11", "100", "0", "1011" };
            var result = _unit.IsOne(words);
            Assert.IsTrue(result == "Yes");
        }

        /// <summary>
        /// {"No", "not"}
        /// Returns: "Yes"
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            var words = new[] { "No", "not" };
            var result = _unit.IsOne(words);
            Assert.IsTrue(result == "Yes");
        }
    }
}
