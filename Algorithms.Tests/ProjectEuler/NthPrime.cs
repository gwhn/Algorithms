using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class NthPrime
    {
        private readonly Code.ProjectEuler.NthPrime _unit = new Code.ProjectEuler.NthPrime();

        [TestMethod]
        public void Test1()
        {
            const int n = 6;
            var result = _unit.Find(n);
            Assert.IsTrue(result == 13);
        }

        [TestMethod]
        public void Test2()
        {
            const int n = 10001;
            var result = _unit.Find(n);
            Assert.IsTrue(result == 104743);
        }
    }
}
