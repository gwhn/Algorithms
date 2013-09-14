using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class ArcadeManao
    {
        private readonly Code.ArcadeManao _unit = new Code.ArcadeManao();

        /// <summary>
        /// {"XXXX....",
        ///  "...X.XXX",
        ///  "XXX..X..",
        ///  "......X.",
        ///  "XXXXXXXX"}
        /// 2
        /// 4
        /// Returns: 2
        /// The example from the problem statement. 
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var level = new[]
                {
                    "XXXX....",
                    "...X.XXX",
                    "XXX..X..",
                    "......X.",
                    "XXXXXXXX"
                };
            const int coinRow = 2;
            const int coinColumn = 4;
            var result = _unit.ShortestLadder(level, coinRow, coinColumn);
            Assert.IsTrue(result == 2);
        }

        /// <summary>
        /// {"XXXX",
        ///  "...X",
        ///  "XXXX"}
        /// 1
        /// 1
        /// Returns: 1
        /// Manao can use the ladder to climb from the ground to cell (2, 4), 
        /// then to cell (1, 4) and then he can walk right to the coin. 
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var level = new[]
                {
                    "XXXX",
                    "...X",
                    "XXXX"
                };
            const int coinRow = 1;
            const int coinColumn = 1;
            var result = _unit.ShortestLadder(level, coinRow, coinColumn);
            Assert.IsTrue(result == 1);
        }

        /// <summary>
        /// {"..X..",
        ///  ".X.X.",
        ///  "X...X",
        ///  ".X.X.",
        ///  "..X..",
        ///  "XXXXX"}
        /// 1
        /// 3
        /// Returns: 4
        /// With a ladder of length 4, Manao can first climb to cell (5, 3) and then right to (1, 3). 
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var level = new[]
                {
                    "..X..",
                    ".X.X.",
                    "X...X",
                    ".X.X.",
                    "..X..",
                    "XXXXX"
                };
            const int coinRow = 1;
            const int coinColumn = 3;
            var result = _unit.ShortestLadder(level, coinRow, coinColumn);
            Assert.IsTrue(result == 4);
        }

        /// <summary>
        /// {"X"}
        /// 1
        /// 1
        /// Returns: 0
        /// Manao begins in the same cell as the coin. 
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            var level = new[] { "X" };
            const int coinRow = 1;
            const int coinColumn = 1;
            var result = _unit.ShortestLadder(level, coinRow, coinColumn);
            Assert.IsTrue(result == 0);
        }

        /// <summary>
        /// {"XXXXXXXXXX",
        ///  "...X......",
        ///  "XXX.......",
        ///  "X.....XXXX",
        ///  "..XXXXX..X",
        ///  ".........X",
        ///  ".........X",
        ///  "XXXXXXXXXX"}
        /// 1
        /// 1
        /// Returns: 2
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            var level = new[]
                {
                    "XXXXXXXXXX", 
                    "...X......", 
                    "XXX.......", 
                    "X.....XXXX", 
                    "..XXXXX..X", 
                    ".........X", 
                    ".........X",
                    "XXXXXXXXXX"
                };
            const int coinRow = 1;
            const int coinColumn = 1;
            var result = _unit.ShortestLadder(level, coinRow, coinColumn);
            Assert.IsTrue(result == 2);
        }
    }
}
