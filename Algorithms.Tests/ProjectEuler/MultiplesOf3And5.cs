using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class MultiplesOf3And5
    {
        private readonly Code.ProjectEuler.MultiplesOf3And5 _unit = new Code.ProjectEuler.MultiplesOf3And5();

        [TestMethod]
        public void Test1()
        {
            const int max = 10;
            var result = _unit.Sum(max);
            Assert.IsTrue(result == 23);
        }

        [TestMethod]
        public void Test2()
        {
            const int max = 1000;
            var result = _unit.Sum(max);
            Assert.IsTrue(result == 233168);
        }
    }
}
