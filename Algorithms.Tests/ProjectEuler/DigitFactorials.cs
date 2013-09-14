using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class DigitFactorials
    {
        private readonly Code.ProjectEuler.DigitFactorials _unit = new Code.ProjectEuler.DigitFactorials();

        [TestMethod]
        public void Test1()
        {
            var result = _unit.Solve();
            Assert.IsTrue(result == 40730);
        }
    }
}
