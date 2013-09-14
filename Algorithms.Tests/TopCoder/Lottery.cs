using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class Lottery
    {
        private readonly Code.Lottery _unit = new Code.Lottery();

        /// <summary>
        /// { "PICK ANY TWO: 10 2 F F",
        ///   "PICK TWO IN ORDER: 10 2 T F",
        ///   "PICK TWO DIFFERENT: 10 2 F T",
        ///   "PICK TWO LIMITED: 10 2 T T" }
        /// Returns: 
        /// { "PICK TWO LIMITED",
        ///   "PICK TWO IN ORDER",
        ///   "PICK TWO DIFFERENT",
        ///   "PICK ANY TWO" }
        /// The "PICK ANY TWO" game lets either blank be a number from 1 to 10. 
        /// Therefore, there are 10 * 10 = 100 possible tickets, and your odds of winning are 1/100.
        /// The "PICK TWO IN ORDER" game means that the first number cannot be greater than the second number. 
        /// This eliminates 45 possible tickets, leaving us with 55 valid ones. The odds of winning are 1/55.
        /// The "PICK TWO DIFFERENT" game only disallows tickets where the first and second numbers are the same. 
        /// There are 10 such tickets, leaving the odds of winning at 1/90.
        /// Finally, the "PICK TWO LIMITED" game disallows an additional 10 tickets from the 45 disallowed in "PICK TWO IN ORDER". 
        /// The odds of winning this game are 1/45.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var rules = new[]
                {
                    "PICK ANY TWO: 10 2 F F",
                    "PICK TWO IN ORDER: 10 2 T F",
                    "PICK TWO DIFFERENT: 10 2 F T",
                    "PICK TWO LIMITED: 10 2 T T"
                };
            var result = _unit.SortByOdds(rules);
            Assert.IsTrue(result[0] == "PICK TWO LIMITED");
            Assert.IsTrue(result[1] == "PICK TWO IN ORDER");
            Assert.IsTrue(result[2] == "PICK TWO DIFFERENT");
            Assert.IsTrue(result[3] == "PICK ANY TWO");
        }

        /// <summary>
        /// { "INDIGO: 93 8 T F",
        ///   "ORANGE: 29 8 F T",
        ///   "VIOLET: 76 6 F F",
        ///   "BLUE: 100 8 T T",
        ///   "RED: 99 8 T T",
        ///   "GREEN: 78 6 F T",
        ///   "YELLOW: 75 6 F F" }
        /// Returns: 
        /// { "RED",  
        ///   "ORANGE",  
        ///   "YELLOW",  
        ///   "GREEN",  
        ///   "BLUE",  
        ///   "INDIGO",  
        ///   "VIOLET" }
        /// Note that INDIGO and BLUE both have the exact same odds (1/186087894300). 
        /// BLUE is listed first because it comes before INDIGO alphabetically.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var rules = new[]
                {
                    "INDIGO: 93 8 T F",
                    "ORANGE: 29 8 F T",
                    "VIOLET: 76 6 F F",
                    "BLUE: 100 8 T T",
                    "RED: 99 8 T T",
                    "GREEN: 78 6 F T",
                    "YELLOW: 75 6 F F"
                };
            var result = _unit.SortByOdds(rules);
            Assert.IsTrue(result[0] == "RED");
            Assert.IsTrue(result[1] == "ORANGE");
            Assert.IsTrue(result[2] == "YELLOW");
            Assert.IsTrue(result[3] == "GREEN");
            Assert.IsTrue(result[4] == "BLUE");
            Assert.IsTrue(result[5] == "INDIGO");
            Assert.IsTrue(result[6] == "VIOLET");
        }

        /// <summary>
        /// { }
        /// Returns: 
        /// { }
        /// Empty case
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var rules = new string[] {};
            var result = _unit.SortByOdds(rules);
            Assert.IsTrue(result.Length == 0);            
        }
    }
}
