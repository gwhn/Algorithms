using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class JumpFurther
    {
        private readonly Code.JumpFurther _unit = new Code.JumpFurther();

        /// <summary>
        /// 2
        /// 2
        /// Returns: 3
        /// The optimal strategy is to jump upwards twice: 
        /// from step 0 to step 1, and then from step 1 to step 3. This trajectory avoids the broken step.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int N = 2;
            const int badStep = 2;
            var result = _unit.Furthest(N, badStep);
            Assert.IsTrue(result == 3);
        }

        /// <summary>
        /// 2
        /// 1
        /// Returns: 2
        /// In this case step 1 is broken, so Jiro cannot jump upwards as his first action. 
        /// The optimal strategy is to first stay on step 0, and then to jump from step 0 to step 2.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int N = 2;
            const int badStep = 1;
            var result = _unit.Furthest(N, badStep);
            Assert.IsTrue(result == 2);
        }

        /// <summary>
        /// 3
        /// 3
        /// Returns: 5
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int N = 3;
            const int badStep = 3;
            var result = _unit.Furthest(N, badStep);
            Assert.IsTrue(result == 5);
        }

        /// <summary>
        /// 1313
        /// 5858
        /// Returns: 862641
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const int N = 1313;
            const int badStep = 5858;
            var result = _unit.Furthest(N, badStep);
            Assert.IsTrue(result == 862641);
        }

        /// <summary>
        /// 1
        /// 757065
        /// Returns: 1
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const int N = 1;
            const int badStep = 757065;
            var result = _unit.Furthest(N, badStep);
            Assert.IsTrue(result == 1);
        }
    }
}
