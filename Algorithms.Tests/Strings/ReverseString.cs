using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.Strings
{
    [TestClass]
    public class ReverseString
    {
        const string Text = "Hello";
        const string ReverseText = "olleH";

        [TestMethod]
        public void TestIterativeReverse()
        {
            var result = Code.Strings.ReverseString.IterativeReverse(Text);
            Assert.IsTrue(result == ReverseText);
        }

        [TestMethod]
        public void TestRecursiveReverse()
        {
            var result = Code.Strings.ReverseString.RecursiveReverse(Text);
            Assert.IsTrue(result == ReverseText);
        }
    }
}
