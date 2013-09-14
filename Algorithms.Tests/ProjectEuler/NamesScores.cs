using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class NamesScores
    {
        private readonly Code.ProjectEuler.NamesScores _unit = new Code.ProjectEuler.NamesScores();

        [TestMethod]
        public void Test1()
        {
            const string path = @"C:\Users\guy\Documents\Visual Studio 2012\Projects\Algorithms\Algorithms.Tests\Resources\names.txt";
            var result = _unit.Solve(path);
            Assert.IsTrue(result == 871198282);
        }
    }
}
