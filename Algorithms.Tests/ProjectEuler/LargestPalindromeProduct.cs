using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class LargestPalindromeProduct
    {
        private readonly Code.ProjectEuler.LargestPalindromeProduct _unit = new Code.ProjectEuler.LargestPalindromeProduct();

        [TestMethod]
        public void Test1()
        {
            const int n = 2;
            var result = _unit.Max(n);
            Assert.IsTrue(result == 9009);
        }

        [TestMethod]
        public void Test3()
        {
            const int n = 3;
            var result = _unit.Max(n);
            Assert.IsTrue(result == 906609);
        }
    }
}
