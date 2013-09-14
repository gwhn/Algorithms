using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class AgeEncoding
    {
        private readonly Code.AgeEncoding _unit = new Code.AgeEncoding();

        /// <summary>
        /// 10
        /// "00010"
        /// Returns: 10.0
        /// This is the first example from the statement: simply a decimal notation of the given age. 
        /// Note that notation can have leading zeroes.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int age = 10;
            const string candlesLine = "00010";
            var result = _unit.GetRadix(age, candlesLine);
            Assert.IsTrue(result >= 10.0D - 1e-9);
            Assert.IsTrue(result <= 10.0D + 1e-9);
        }

        /// <summary>
        /// 21
        /// "10101"
        /// Returns: 2.0
        /// This is the second example from the statement: 
        /// "10101" is a binary notation of the given age.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int age = 21;
            const string candlesLine = "10101";
            var result = _unit.GetRadix(age, candlesLine);
            Assert.IsTrue(result >= 2.0D - 1e-9);
            Assert.IsTrue(result <= 2.0D + 1e-9);
        }

        /// <summary>
        /// 6
        /// "10100"
        /// Returns: 1.414213562373095
        /// This is the third example from the statement.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int age = 6;
            const string candlesLine = "10100";
            var result = _unit.GetRadix(age, candlesLine);
            Assert.IsTrue(result >= 1.414213562373095D - 1e-9);
            Assert.IsTrue(result <= 1.414213562373095D + 1e-9);
        }

        /// <summary>
        /// 21
        /// "10111111110111101111111100111111110111111111111100"
        /// Returns: 0.9685012944510603
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const int age = 21;
            const string candlesLine = "10111111110111101111111100111111110111111111111100";
            var result = _unit.GetRadix(age, candlesLine);
            Assert.IsTrue(result >= 0.9685012944510603D - 1e-9);
            Assert.IsTrue(result <= 0.9685012944510603D + 1e-9);
        }

        /// <summary>
        /// 16
        /// "1"
        /// Returns: -1.0
        /// In any base, "1" represents the age of 1, so it's impossible to get the age of 16.
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const int age = 16;
            const string candlesLine = "1";
            var result = _unit.GetRadix(age, candlesLine);
            Assert.IsTrue(result >= -1.0D - 1e-9);
            Assert.IsTrue(result <= -1.0D + 1e-9);
        }

        /// <summary>
        /// 1
        /// "1"
        /// Returns: -2.0
        /// In any base, "1" represents the age of 1.
        /// </summary>
        [TestMethod]
        public void Test6()
        {
            const int age = 1;
            const string candlesLine = "1";
            var result = _unit.GetRadix(age, candlesLine);
            Assert.IsTrue(result >= -2.0D - 1e-9);
            Assert.IsTrue(result <= -2.0D + 1e-9);
        }

        /// <summary>
        /// 1
        /// "001000"
        /// Returns: 1.0
        /// </summary>
        [TestMethod]
        public void Test7()
        {
            const int age = 1;
            const string candlesLine = "001000";
            var result = _unit.GetRadix(age, candlesLine);
            Assert.IsTrue(result >= 1.0D - 1e-9);
            Assert.IsTrue(result <= 1.0D + 1e-9);
        }
    }
}
