using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class SpecialPythagoreanTriplet
    {
        private readonly Code.ProjectEuler.SpecialPythagoreanTriplet _unit = new Code.ProjectEuler.SpecialPythagoreanTriplet();

        [TestMethod]
        public void Test1()
        {
            const int n = 12;
            var result = _unit.Product(n);
            Assert.IsTrue(result == 60);
        }

        [TestMethod]
        public void Test2()
        {
            const int n = 1000;
            var result = _unit.Product(n);
            Assert.IsTrue(result == 31875000);
        }
    }
}
