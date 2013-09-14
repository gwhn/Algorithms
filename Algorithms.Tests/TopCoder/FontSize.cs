using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class FontSize
    {
        private readonly Code.FontSize _unit = new Code.FontSize();

        /// <summary>
        /// "Dead Beef"
        /// {6,6,6,7,7,7,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9}
        /// {5,5,5,4,4,4,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9}
        /// Returns: 49
        /// D   e   a   d  (space)  B   e   e   f
        /// 7+1+4+1+5+1+4+1 + 3 + 1+6+1+4+1+4+1+4 = 49
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const string sentence = "Dead Beef";
            var uppercase = new[] { 6, 6, 6, 7, 7, 7, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 };
            var lowercase = new[] { 5, 5, 5, 4, 4, 4, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 };
            var result = _unit.GetPixelWidth(sentence, uppercase, lowercase);
            Assert.IsTrue(result == 49);
        }

        /// <summary>
        /// "Hello World"
        /// {7,8,8,8,7,8,8,8,7,8,8,8,8,8,7,8,8,8,8,8,7,8,8,8,8,8}
        /// {5,6,6,6,5,6,6,6,5,6,6,6,6,6,5,6,6,6,6,6,5,6,6,6,6,6}
        /// Returns: 74
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const string sentence = "Hello World";
            var uppercase = new[] { 7, 8, 8, 8, 7, 8, 8, 8, 7, 8, 8, 8, 8, 8, 7, 8, 8, 8, 8, 8, 7, 8, 8, 8, 8, 8 };
            var lowercase = new[] { 5, 6, 6, 6, 5, 6, 6, 6, 5, 6, 6, 6, 6, 6, 5, 6, 6, 6, 6, 6, 5, 6, 6, 6, 6, 6 };
            var result = _unit.GetPixelWidth(sentence, uppercase, lowercase);
            Assert.IsTrue(result == 74);
        }

        /// <summary>
        /// "Hello World"
        /// {7,7,7,7,7,7,7,8,7,7,7,7,7,7,7,7,7,7,7,7,7,7,9,7,7,7}
        /// {5,5,5,6,6,5,5,5,5,5,5,1,5,5,6,5,5,6,5,5,5,5,5,5,5,5}
        /// Returns: 63
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const string sentence = "Hello World";
            var uppercase = new[] { 7, 7, 7, 7, 7, 7, 7, 8, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 9, 7, 7, 7 };
            var lowercase = new[] { 5, 5, 5, 6, 6, 5, 5, 5, 5, 5, 5, 1, 5, 5, 6, 5,          5, 6, 5, 5, 5, 5, 5, 5, 5, 5 };
            var result = _unit.GetPixelWidth(sentence, uppercase, lowercase);
            Assert.IsTrue(result == 63);
        }

        /// <summary>
        /// "ThE qUiCk BrOwN fOx JuMpEd OvEr ThE lAzY dOg"
        /// {36,35,34,33,32,31,30,29,28,27,26,25,24,23,22,21,20,19,18,17,16,15,14,13,12,11}
        /// {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26}
        /// Returns: 778
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const string sentence = "ThE qUiCk BrOwN fOx JuMpEd OvEr ThE lAzY dOg";
            var uppercase = new[] { 36, 35, 34, 33, 32, 31, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11 };
            var lowercase = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };
            var result = _unit.GetPixelWidth(sentence, uppercase, lowercase);
            Assert.IsTrue(result == 778);
        }

        /// <summary>
        /// "two  spaces"
        /// {9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9}
        /// {3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3}
        /// Returns: 43
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const string sentence = "two  spaces";
            var uppercase = new[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 };
            var lowercase = new[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 };
            var result = _unit.GetPixelWidth(sentence, uppercase, lowercase);
            Assert.IsTrue(result == 43);
        }
    }
}
