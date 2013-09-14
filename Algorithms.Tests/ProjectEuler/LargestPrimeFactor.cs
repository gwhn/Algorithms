using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class LargestPrimeFactor
    {
        private readonly Code.ProjectEuler.LargestPrimeFactor _unit = new Code.ProjectEuler.LargestPrimeFactor();

        [TestMethod]
        public void Test1()
        {
            const long n = 13195;
            var result = _unit.Max(n);
            Assert.IsTrue(result == 29);
        }

        [TestMethod]
        public void Test2()
        {
            const long n = 600851475143;
            var result = _unit.Max(n);
            Assert.IsTrue(result == 6857);
        }
    }
}
