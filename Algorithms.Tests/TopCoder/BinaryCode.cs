using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class BinaryCode
    {
        private readonly Code.BinaryCode _unit = new Code.BinaryCode();

        /// <summary>
        /// "123210122"
        /// Returns: { "011100011",  "NONE" }
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const string message = "123210122";
            var result = _unit.Decode(message);
            Assert.IsTrue(result[0] == "011100011");
            Assert.IsTrue(result[1] == "NONE");
        }

        /// <summary>
        /// "11"
        /// Returns: { "01",  "10" }
        /// We know that one of the digits must be '1', and the other must be '0'. We return both cases.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const string message = "11";
            var result = _unit.Decode(message);
            Assert.IsTrue(result[0] == "01");
            Assert.IsTrue(result[1] == "10");
        }

        /// <summary>
        /// "22111"
        /// Returns: { "NONE",  "11001" }
        /// Since the first digit of the encrypted string is '2', the first two digits of the original string must be '1'. Our test fails when we try to assume that P[0] = 0.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const string message = "22111";
            var result = _unit.Decode(message);
            Assert.IsTrue(result[0] == "NONE");
            Assert.IsTrue(result[1] == "11001");
        }
        
        /// <summary>
        /// "123210120"
        /// Returns: { "NONE",  "NONE" }
        /// This is the same as the first example, but the rightmost digit has been changed to something inconsistent with the rest of the original string. No solutions are possible.
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const string message = "123210120";
            var result = _unit.Decode(message);
            Assert.IsTrue(result[0] == "NONE");
            Assert.IsTrue(result[1] == "NONE");
        }
        
        /// <summary>
        /// "3"
        /// Returns: { "NONE",  "NONE" }
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const string message = "3";
            var result = _unit.Decode(message);
            Assert.IsTrue(result[0] == "NONE");
            Assert.IsTrue(result[1] == "NONE");
        }
        
        /// <summary>
        /// "12221112222221112221111111112221111"
        /// Returns: 
        /// { "01101001101101001101001001001101001",
        ///   "10110010110110010110010010010110010" }
        /// </summary>
        [TestMethod]
        public void Test6()
        {
            const string message = "12221112222221112221111111112221111";
            var result = _unit.Decode(message);
            Assert.IsTrue(result[0] == "01101001101101001101001001001101001");
            Assert.IsTrue(result[1] == "10110010110110010110010010010110010");
        }
    }
}
