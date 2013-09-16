using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class Palindrome
    {
        [TestMethod]
        public void NumberIsPalindrome()
        {
            const int number = 1234321;
            var result = Code.Palindrome.IsPalindrome(number);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NumberIsNotPalindrome()
        {
            const int number = 12345321;
            var result = Code.Palindrome.IsPalindrome(number);
            Assert.IsFalse(result);            
        }

        [TestMethod]
        public void StringIsPalindrome()
        {
            const string text = "tatarratat";
            var result = Code.Palindrome.IsPalindrome(text);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void StringIsNotPalindrome()
        {
            const string text = "something";
            var result = Code.Palindrome.IsPalindrome(text);
            Assert.IsFalse(result);            
        }
    }
}
