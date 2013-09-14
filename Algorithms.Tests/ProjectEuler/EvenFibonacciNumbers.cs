using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class EvenFibonacciNumbers
    {
        private readonly Code.ProjectEuler.EvenFibonacciNumbers _unit = new Code.ProjectEuler.EvenFibonacciNumbers();

        [TestMethod]
        public void Test1()
        {
            const int max = 4000000;
            var result = _unit.Sum(max);
            Assert.IsTrue(result == 4613732);
        }
    }
}
