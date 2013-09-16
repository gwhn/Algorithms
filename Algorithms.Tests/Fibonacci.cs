using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class FibonacciSequence
    {
        [TestMethod]
        public void Test1()
        {
            const int n = 1;
            var result = Code.FibonacciSequence.Fibonacci(n);
            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void Test2()
        {
            const int n = 2;
            var result = Code.FibonacciSequence.Fibonacci(n);
            Assert.IsTrue(result == 2);
        }

        [TestMethod]
        public void Test3()
        {
            const int n = 3;
            var result = Code.FibonacciSequence.Fibonacci(n);
            Assert.IsTrue(result == 3);
        }

        [TestMethod]
        public void Test4()
        {
            const int n = 4;
            var result = Code.FibonacciSequence.Fibonacci(n);
            Assert.IsTrue(result == 5);
        }

        [TestMethod]
        public void Test5()
        {
            const int n = 5;
            var result = Code.FibonacciSequence.Fibonacci(n);
            Assert.IsTrue(result == 8);
        }
    }
}
