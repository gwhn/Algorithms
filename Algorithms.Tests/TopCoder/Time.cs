using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class Time
    {
        private readonly Code.Time _unit = new Code.Time();

        /// <summary>
        /// 0
        /// Returns: "0:0:0"
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int seconds = 0;
            var result = _unit.WhatTime(seconds);
            Assert.IsTrue(result == "0:0:0");
        }

        /// <summary>
        /// 3661
        /// Returns: "1:1:1"
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int seconds = 3661;
            var result = _unit.WhatTime(seconds);
            Assert.IsTrue(result == "1:1:1");
        }
        
        /// <summary>
        /// 5436
        /// Returns: "1:30:36"
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int seconds = 5436;
            var result = _unit.WhatTime(seconds);
            Assert.IsTrue(result == "1:30:36");
        }

        /// <summary>
        /// 86399
        /// Returns: "23:59:59"
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const int seconds = 86399;
            var result = _unit.WhatTime(seconds);
            Assert.IsTrue(result == "23:59:59");
        }
    }
}
