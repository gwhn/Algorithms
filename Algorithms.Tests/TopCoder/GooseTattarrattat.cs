using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class GooseTattarrattat
    {
        private readonly Code.GooseTattarrattat _unit = new Code.GooseTattarrattat();

        /// <summary>
        /// "geese"
        /// Returns: 2
        /// There are many ways how Tattarrattat can change this S into a palindrome. 
        /// For example, she could do it in two steps as follows: 
        /// 1.Change all 'g's to 'e's: this takes 1 second and produces the string "eeese".
        /// 2.Change all 'e's to 's's: this takes 4 seconds and produces the string "sssss".
        /// This way took her 1+4 = 5 seconds. 
        /// However, there are faster ways. The best one only takes 2 seconds. 
        /// For example, she can first change all 'g's to 'e's (1 second), 
        /// and then change all 's's to 'e's (1 second), obtaining the palindrome "eeeee". 
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const string S = "geese";
            var result = _unit.GetMin(S);
            Assert.IsTrue(result == 2);
        }

        /// <summary>
        /// "tattarrattat"
        /// Returns: 0
        /// This string is already a palindrome so no changes are needed. 
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const string S = "tattarrattat";
            var result = _unit.GetMin(S);
            Assert.IsTrue(result == 0);
        }

        /// <summary>
        /// "xyyzzzxxx"
        /// Returns: 2
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const string S = "xyyzzzxxx";
            var result = _unit.GetMin(S);
            Assert.IsTrue(result == 2);
        }

        /// <summary>
        /// "xrepayuyubctwtykrauccnquqfuqvccuaakylwlcjuyhyammag"
        /// Returns: 11
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const string S = "xrepayuyubctwtykrauccnquqfuqvccuaakylwlcjuyhyammag";
            var result = _unit.GetMin(S);
            Assert.IsTrue(result == 11);
        }

        /// <summary>
        /// "abaabb"
        /// Returns: 3
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const string S = "abaabb";
            var result = _unit.GetMin(S);
            Assert.IsTrue(result == 3);
        }
    }
}
