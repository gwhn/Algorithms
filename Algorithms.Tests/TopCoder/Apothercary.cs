using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class Apothercary
    {
        private readonly Code.Apothecary _unit = new Apothecary();

        /// <summary>
        /// 17
        /// Returns: { -9,  -1,  27 }
        /// The example above. 
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int W = 17;
            var result = _unit.Balance(W);
            Assert.IsTrue(result.Length == 3);
            Assert.IsTrue(result[0] == -9);
            Assert.IsTrue(result[1] == -1);
            Assert.IsTrue(result[2] == 27);
        }

        /// <summary>
        /// 1
        /// Returns: { 1 }
        /// A 1-grain weight is placed in the pan opposite the object being measured. 
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int W = 1;
            var result = _unit.Balance(W);
            Assert.IsTrue(result.Length == 1);
            Assert.IsTrue(result[0] == 1);
        }

        /// <summary>
        /// 2016
        /// Returns: { -243,  -9,  81,  2187 }
        /// A 9-grain weight and a 243-grain weight are placed in the pan with the object, and an 81-grain weight and a 2187-grain weight are placed in the opposite pan. 
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int W = 2016;
            var result = _unit.Balance(W);
            Assert.IsTrue(result.Length == 4);
            Assert.IsTrue(result[0] == -243);
            Assert.IsTrue(result[1] == -9);
            Assert.IsTrue(result[2] == 81);
            Assert.IsTrue(result[3] == 2187);
        }

        /// <summary>
        /// 1000000
        /// Returns: { -531441,  -59049,  -6561,  -243,  -27,  1,  81,  729,  2187,  1594323 }
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const int W = 1000000;
            var result = _unit.Balance(W);
            Assert.IsTrue(result.Length == 10);
            Assert.IsTrue(result[0] == -531441);
            Assert.IsTrue(result[1] == -59049);
            Assert.IsTrue(result[2] == -6561);
            Assert.IsTrue(result[3] == -243);
            Assert.IsTrue(result[4] == -27);
            Assert.IsTrue(result[5] == 1);
            Assert.IsTrue(result[6] == 81);
            Assert.IsTrue(result[7] == 729);
            Assert.IsTrue(result[8] == 2187);
            Assert.IsTrue(result[9] == 1594323);
        }
    }
}
