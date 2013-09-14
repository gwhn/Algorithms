using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class LeaguePicks
    {
        private readonly Code.LeaguePicks _unit = new Code.LeaguePicks();

        /// <summary>
        /// 3
        /// 6
        /// 15
        /// Returns: { 3,  10,  15 }
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int position = 3;
            const int friends = 6;
            const int picks = 15;
            var result = _unit.ReturnPicks(position, friends, picks);
            Assert.IsTrue(result.Length == 3);
            Assert.IsTrue(result[0] == 3);
            Assert.IsTrue(result[1] == 10);
            Assert.IsTrue(result[2] == 15);
        }

        /// <summary>
        /// 1
        /// 1
        /// 10
        /// Returns: { 1,  2,  3,  4,  5,  6,  7,  8,  9,  10 }
        /// You're the only player, so you get all the picks.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int position = 1;
            const int friends = 1;
            const int picks = 10;
            var result = _unit.ReturnPicks(position, friends, picks);
            Assert.IsTrue(result.Length == 10);
            Assert.IsTrue(result[0] == 1);
            Assert.IsTrue(result[1] == 2);
            Assert.IsTrue(result[2] == 3);
            Assert.IsTrue(result[3] == 4);
            Assert.IsTrue(result[4] == 5);
            Assert.IsTrue(result[5] == 6);
            Assert.IsTrue(result[6] == 7);
            Assert.IsTrue(result[7] == 8);
            Assert.IsTrue(result[8] == 9);
            Assert.IsTrue(result[9] == 10);
        }

        /// <summary>
        /// 1
        /// 2
        /// 39
        /// Returns: 
        /// { 1,  4,  5,  8,  9,  12,  13,  16,  17,  20,  21,  24,  25,  28,  29,
        ///   32,  33,  36,  37 }
        /// You'll get the 1st and 4th picks in every set of 4.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int position = 1;
            const int friends = 2;
            const int picks = 39;
            var result = _unit.ReturnPicks(position, friends, picks);
            Assert.IsTrue(result.Length == 19);
            Assert.IsTrue(result[0] == 1);
            Assert.IsTrue(result[1] == 4);
            Assert.IsTrue(result[2] == 5);
            Assert.IsTrue(result[3] == 8);
            Assert.IsTrue(result[4] == 9);
            Assert.IsTrue(result[5] == 12);
            Assert.IsTrue(result[6] == 13);
            Assert.IsTrue(result[7] == 16);
            Assert.IsTrue(result[8] == 17);
            Assert.IsTrue(result[9] == 20);
            Assert.IsTrue(result[10] == 21);
            Assert.IsTrue(result[11] == 24);
            Assert.IsTrue(result[12] == 25);
            Assert.IsTrue(result[13] == 28);
            Assert.IsTrue(result[14] == 29);
            Assert.IsTrue(result[15] == 32);
            Assert.IsTrue(result[16] == 33);
            Assert.IsTrue(result[17] == 36);
            Assert.IsTrue(result[18] == 37);
        }

        /// <summary>
        /// 5
        /// 11
        /// 100
        /// Returns: { 5,  18,  27,  40,  49,  62,  71,  84,  93 }
        /// You'll get the 5th and (2*11-5+1) or 18th picks out of every 2*11 picks.
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const int position = 5;
            const int friends = 11;
            const int picks = 100;
            var result = _unit.ReturnPicks(position, friends, picks);
            Assert.IsTrue(result.Length == 9);
            Assert.IsTrue(result[0] == 5);
            Assert.IsTrue(result[1] == 18);
            Assert.IsTrue(result[2] == 27);
            Assert.IsTrue(result[3] == 40);
            Assert.IsTrue(result[4] == 49);
            Assert.IsTrue(result[5] == 62);
            Assert.IsTrue(result[6] == 71);
            Assert.IsTrue(result[7] == 84);
            Assert.IsTrue(result[8] == 93);
        }
    }
}
