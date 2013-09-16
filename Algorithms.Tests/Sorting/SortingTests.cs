using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.Sorting
{
    [TestClass]
    public class SortingTests
    {
        private static readonly int[] Integers = new[] {9, 4, 2, 3, 8, 9, 7, 1, 5};
        private static readonly int[] SortedIntegers = new[] {1, 2, 3, 4, 5, 7, 8, 9, 9};
        private static readonly string[] Strings = new[] {"Guy", "Mary", "Alex", "Colin", "Charles"};
        private static readonly string[] SortedStrings = new[] {"Alex", "Charles", "Colin", "Guy", "Mary"};

        [TestMethod]
        public void BubbleSortIntegerArray()
        {
            Code.Sorting.BubbleSort.SortIntegers(Integers);
            Assert.IsTrue(Integers.Length == SortedIntegers.Length);
            for (int i = 0; i < Integers.Length; i++)
            {
                Assert.IsTrue(Integers[i] == SortedIntegers[i]);
            }
        }

        [TestMethod]
        public void BubbleSortStringArray()
        {
            Code.Sorting.BubbleSort.SortStrings(Strings);
            Assert.IsTrue(Strings.Length == SortedStrings.Length);
            for (int i = 0; i < Strings.Length; i++)
            {
                Assert.IsTrue(Strings[i] == SortedStrings[i]);
            }
        }

        [TestMethod]
        public void InsertionSortIntegerArray()
        {
            Code.Sorting.InsertionSort.Sort(Integers);
            Assert.IsTrue(Integers.Length == SortedIntegers.Length);
            for (int i = 0; i < Integers.Length; i++)
            {
                Assert.IsTrue(Integers[i] == SortedIntegers[i]);
            }
        }

        [TestMethod]
        public void MergeSortIntegerArray()
        {
            var result = Code.Sorting.MergeSort.Sort(Integers);
            Assert.IsTrue(result.Length == SortedIntegers.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.IsTrue(result[i] == SortedIntegers[i]);
            }
        }

        [TestMethod]
        public void QuickSortIntegerArray()
        {
            var result = Code.Sorting.QuickSort.Sort(Integers);
            Assert.IsTrue(result.Length == SortedIntegers.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.IsTrue(result[i] == SortedIntegers[i]);
            }
        }
    }
}
