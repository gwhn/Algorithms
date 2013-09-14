using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class SmallestMultiple
    {
        private readonly Code.ProjectEuler.SmallestMultiple _unit = new Code.ProjectEuler.SmallestMultiple();

        [TestMethod]
        public void Test1()
        {
            const int n = 10;
            var result = _unit.Find(n);
            Assert.IsTrue(result == 2520);
        }

        [TestMethod]
        public void Test2()
        {
            const int n = 20;
            var result = _unit.Find(n);
            Assert.IsTrue(result == 232792560);
        }
    }
}
