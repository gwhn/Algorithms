using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class SchoolAssembly
    {
        private readonly Code.SchoolAssembly _unit = new Code.SchoolAssembly();

        /// <summary>
        /// 1
        /// 5
        /// Returns: 2
        /// Only one kid to buy for. 
        /// Since the first bag you buy could contain 4 of each color, 
        /// you must buy a second bag to ensure the child has 5 of the same color. 
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int kids = 1;
            const int quantity = 5;
            var result = _unit.GetBeans(kids, quantity);
            Assert.IsTrue(result == 2);
        }

        /// <summary>
        /// 1
        /// 2
        /// Returns: 1
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int kids = 1;
            const int quantity = 2;
            var result = _unit.GetBeans(kids, quantity);
            Assert.IsTrue(result == 1);
        }

        /// <summary>
        /// 5
        /// 5
        /// Returns: 3
        /// If we buy 2 bags, we will be able to give 4 of the children 5 beans. 
        /// However, we could be left with 4 beans of each color, requiring the third bag. 
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int kids = 5;
            const int quantity = 5;
            var result = _unit.GetBeans(kids, quantity);
            Assert.IsTrue(result == 3);
        }

        /// <summary>
        /// 223
        /// 15
        /// Returns: 171
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const int kids = 223;
            const int quantity = 15;
            var result = _unit.GetBeans(kids, quantity);
            Assert.IsTrue(result == 171);
        }
    }
}
