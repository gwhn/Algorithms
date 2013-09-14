using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class GroceryBagger
    {
        private readonly Code.GroceryBagger _unit = new Code.GroceryBagger();

        /// <summary>
        /// 2
        /// {"DAIRY",
        ///  "DAIRY",
        ///  "PRODUCE",
        ///  "PRODUCE",
        ///  "PRODUCE",
        ///  "MEAT"}
        /// Returns: 4
        /// Here, you have six items. 
        /// You could put two items in each bag, but you would have to mix item types. 
        /// The single meat item must get its own bag. The two dairy items fit in one bag. 
        /// The three produce items will require two bags. 
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int strength = 2;
            var itemType = new[] {"DAIRY", "DAIRY", "PRODUCE", "PRODUCE", "PRODUCE", "MEAT"};
            var result = _unit.MinimumBags(strength, itemType);
            Assert.IsTrue(result == 4);
        }

        /// <summary>
        /// 3
        /// {"DAIRY",
        ///  "DAIRY",
        ///  "PRODUCE",
        ///  "PRODUCE",
        ///  "PRODUCE",
        ///  "MEAT"}
        /// Returns: 3
        /// Similar to above, but now we have stronger bags. 
        /// Note again, though, that if we were allowed to mix item types, 
        /// we could get away with only 2 bags. 
        /// But since item types cannot be mixed, we need 3 bags. 
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int strength = 3;
            var itemType = new[] {"DAIRY", "DAIRY", "PRODUCE", "PRODUCE", "PRODUCE", "MEAT"};
            var result = _unit.MinimumBags(strength, itemType);
            Assert.IsTrue(result == 3);
        }

        /// <summary>
        /// 10
        /// {}
        /// Returns: 0
        /// The bags are really strong, but we didn't buy anything. 
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int strength = 10;
            var itemType = new string[] {};
            var result = _unit.MinimumBags(strength, itemType);
            Assert.IsTrue(result == 0);
        }

        /// <summary>
        /// 5
        /// {"CANNED",   "CANNED",  "PRODUCE",
        ///  "DAIRY",    "MEAT",    "BREAD",
        ///  "HOUSEHOLD","PRODUCE", "FROZEN",
        ///  "PRODUCE", "DAIRY"}
        /// Returns: 7
        /// Notice that a customer doesn't necessarily pay for the items in any particular order, 
        /// but the bagger still has to be responsible for sorting them out. 
        /// In this case, though, one bag for each item type suffices. 
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const int strength = 5;
            var itemType = new[]
                {
                    "CANNED", "CANNED", "PRODUCE", "DAIRY", "MEAT", "BREAD", "HOUSEHOLD", "PRODUCE", "FROZEN", "PRODUCE",
                    "DAIRY"
                };
            var result = _unit.MinimumBags(strength, itemType);
            Assert.IsTrue(result == 7);
        }

        /// <summary>
        /// 2
        /// {"CANNED",   "CANNED",  "PRODUCE",
        ///  "DAIRY",    "MEAT",    "BREAD",
        ///  "HOUSEHOLD","PRODUCE", "FROZEN",
        ///  "PRODUCE", "DAIRY"}
        /// Returns: 8
        /// As above, but our produce requires two bags now. 
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const int strength = 2;
            var itemType = new[]
                {
                    "CANNED", "CANNED", "PRODUCE", "DAIRY", "MEAT", "BREAD", "HOUSEHOLD", "PRODUCE", "FROZEN", "PRODUCE",
                    "DAIRY"
                };
            var result = _unit.MinimumBags(strength, itemType);
            Assert.IsTrue(result == 8);
        }
    }
}
