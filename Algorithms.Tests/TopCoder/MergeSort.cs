using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class MergeSort
    {
        private readonly Code.MergeSort _unit = new Code.MergeSort();

        /// <summary>
        /// {1, 2, 3, 4}
        /// Returns: 4
        /// {1, 2, 3, 4} is first split to {1, 2} and {3, 4}. 
        /// {1, 2} is split to {1} and {2} and merging to {1, 2} takes one comparison. 
        /// {3, 4} is split to {3} and {4} and merging to {3, 4} also takes one comparison. 
        /// Merging {1, 2} and {3, 4} to {1, 2, 3, 4} takes two comparisons 
        /// (first 1 is compared to 3 and then 2 is compared to 3). 
        /// This makes a total of four comparisons.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var numbers = new[] { 1, 2, 3, 4 };
            var result = _unit.HowManyComparisons(numbers);
            Assert.IsTrue(result == 4);
        }

        /// <summary>
        /// {2, 3, 2}
        /// Returns: 2
        /// {2, 3, 2} is split to {2} and {3, 2}. {3, 2} is split and then merged to {2, 3} making one comparison. 
        /// {2} and {2, 3} are merged to {2, 2, 3} also making one comparison, which totals to two comparisons made.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var numbers = new[] { 2, 3, 2 };
            var result = _unit.HowManyComparisons(numbers);
            Assert.IsTrue(result == 2);
        }

        /// <summary>
        /// {-17}
        /// Returns: 0
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var numbers = new[]{-17};
            var result = _unit.HowManyComparisons(numbers);
            Assert.IsTrue(result == 0);
        }

        /// <summary>
        /// {}
        /// Returns: 0
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            var numbers = new int[]{};
            var result = _unit.HowManyComparisons(numbers);
            Assert.IsTrue(result == 0);
        }

        /// <summary>
        /// {-2000000000,2000000000,0,0,0,-2000000000,2000000000,0,0,0}
        /// Returns: 19
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            var numbers = new[] { -2000000000, 2000000000, 0, 0, 0, -2000000000, 2000000000, 0, 0, 0 };
            var result = _unit.HowManyComparisons(numbers);
            Assert.IsTrue(result == 19);
        }
    }
}
