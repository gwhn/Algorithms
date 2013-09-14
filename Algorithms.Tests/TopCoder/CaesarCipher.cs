using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class CaesarCipher
    {
        private readonly Code.CaesarCipher _unit = new Code.CaesarCipher();

        /// <summary>
        /// "VQREQFGT"
        /// 2
        /// Returns: "TOPCODER"
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const string cipherText = "VQREQFGT";
            const int shift = 2;
            var result = _unit.Decode(cipherText, shift);
            Assert.IsTrue(result == "TOPCODER");
        }

        /// <summary>
        /// "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        /// 10
        /// Returns: "QRSTUVWXYZABCDEFGHIJKLMNOP"
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const string cipherText = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const int shift = 10;
            var result = _unit.Decode(cipherText, shift);
            Assert.IsTrue(result == "QRSTUVWXYZABCDEFGHIJKLMNOP");
        }

        /// <summary>
        /// "TOPCODER"
        /// 0
        /// Returns: "TOPCODER"
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const string cipherText = "TOPCODER";
            const int shift = 0;
            var result = _unit.Decode(cipherText, shift);
            Assert.IsTrue(result == "TOPCODER");
        }

        /// <summary>
        /// "ZWBGLZ"
        /// 25
        /// Returns: "AXCHMA"
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const string cipherText = "ZWBGLZ";
            const int shift = 25;
            var result = _unit.Decode(cipherText, shift);
            Assert.IsTrue(result == "AXCHMA");
        }

        /// <summary>
        /// "DBNPCBQ"
        /// 1
        /// Returns: "CAMOBAP"
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const string cipherText = "DBNPCBQ";
            const int shift = 1;
            var result = _unit.Decode(cipherText, shift);
            Assert.IsTrue(result == "CAMOBAP");
        }

        /// <summary>
        /// "LIPPSASVPH"
        /// 4
        /// Returns: "HELLOWORLD"
        /// </summary>
        [TestMethod]
        public void Test6()
        {
            const string cipherText = "LIPPSASVPH";
            const int shift = 4;
            var result = _unit.Decode(cipherText, shift);
            Assert.IsTrue(result == "HELLOWORLD");
        }
    }
}
