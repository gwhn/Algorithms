using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class FanFailure
    {
        private readonly Code.FanFailure _unit = new Code.FanFailure();

        /// <summary>
        /// {1,2,3}
        /// 2
        /// Returns: { 2,  1 }
        /// Example from the problem statement. 
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var capacities = new[] { 1, 2, 3 };
            const int minCooling = 2;
            var result = _unit.GetRange(capacities, minCooling);
            Assert.IsTrue(result.Length == 2);
            Assert.IsTrue(result[0] == 2);
            Assert.IsTrue(result[1] == 1);
        }

        /// <summary>
        /// {8,5,6,7}
        /// 22
        /// Returns: { 0,  0 }
        /// No fans can fail in this system. 
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var capacities = new[] { 8, 5, 6, 7 };
            const int minCooling = 22;
            var result = _unit.GetRange(capacities, minCooling);
            Assert.IsTrue(result.Length == 2);
            Assert.IsTrue(result[0] == 0);
            Assert.IsTrue(result[1] == 0);
        }

        /// <summary>
        /// {676, 11, 223, 413, 823, 122, 547, 187, 28}
        /// 1000
        /// Returns: { 7,  2 }
        /// If you eliminate fans with 676, 11, 413, 122, 547, 187, and 28, 
        /// you are left with 223 + 823 = 1046 units of cooling, which is sufficient, 
        /// yielding an MFS size of 7. 
        /// If you eliminate 676, 823, and 547, you are left with only 984 units of cooling. 
        /// All combinations of 2 or less fans breaking leaves sufficient cooling, so the MFC is 2. 
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var capacities = new[] { 676, 11, 223, 413, 823, 122, 547, 187, 28 };
            const int minCooling = 1000;
            var result = _unit.GetRange(capacities, minCooling);
            Assert.IsTrue(result.Length == 2);
            Assert.IsTrue(result[0] == 7);
            Assert.IsTrue(result[1] == 2);
        }

        /// <summary>
        /// {955, 96, 161, 259, 642, 242, 772, 369, 311, 785,
        ///  92, 991, 620, 394, 128, 774, 973, 94, 681, 771,
        ///  916, 373, 523, 100, 220, 993, 472, 798, 132, 361,
        ///  33, 362, 573, 624, 722, 520, 451, 231, 37, 921,
        ///  408, 170, 303, 559, 866, 412, 339, 757, 822, 192}
        /// 3619
        /// Returns: { 46,  30 }
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            var capacities = new[]
                {
                    955, 96, 161, 259, 642, 242, 772, 369, 311, 785, 92, 991, 620, 394, 128, 774, 973, 94, 681, 771, 916,
                    373, 523, 100, 220, 993, 472, 798, 132, 361, 33, 362, 573, 624, 722, 520, 451, 231, 37, 921, 408,
                    170, 303, 559, 866, 412, 339, 757, 822, 192
                };
            const int minCooling = 3619;
            var result = _unit.GetRange(capacities, minCooling);
            Assert.IsTrue(result.Length == 2);
            Assert.IsTrue(result[0] == 46);
            Assert.IsTrue(result[1] == 30);
        }
    }
}
