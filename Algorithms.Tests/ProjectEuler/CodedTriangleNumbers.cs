using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class CodedTriangleNumbers
    {
        private readonly Code.ProjectEuler.CodedTriangleNumbers _unit = new Code.ProjectEuler.CodedTriangleNumbers();

        [TestMethod]
        public void Test1()
        {
            const string path = @"C:\Users\guy\Documents\Visual Studio 2012\Projects\Algorithms\Algorithms.Tests\Resources\words.txt";
            var words = File.ReadAllText(path).Replace("\"", "").Split(',');
            var result = _unit.Solve(words);
            Assert.IsTrue(result == 162);
        }
    }
}
