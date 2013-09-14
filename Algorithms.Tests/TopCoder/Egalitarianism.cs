using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class Egalitarianism
    {
        private readonly Code.Egalitarianism _unit = new Code.Egalitarianism();

        /// <summary>
        /// {"NYN",
        ///  "YNY",
        ///  "NYN"}
        /// 10
        /// Returns: 20
        /// The kingdom has three citizens. 
        /// Citizens 0 and 1 are friends. Also, citizens 1 and 2 are friends. 
        /// The greatest possible money difference between any two citizens is $20, as in the following configuration: 
        /// citizen 0 has $100; citizen 1 has $110; citizen 2 has $120. 
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var isFriend = new[]{"NYN","YNY","NYN"};
            const int d = 10;
            var result = _unit.MaxDifference(isFriend, d);
            Assert.IsTrue(result == 20);
        }

        /// <summary>
        /// {"NN",
        ///  "NN"}
        /// 1
        /// Returns: -1
        /// Since citizens 0 and 1 are not friends, there are no constraints between them. 
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var isFriend = new[]{"NN","NN"};
            const int d = 1;
            var result = _unit.MaxDifference(isFriend, d);
            Assert.IsTrue(result == -1);
        }

        /// <summary>
        /// {"NNYNNN",
        ///  "NNYNNN",
        ///  "YYNYNN",
        ///  "NNYNYY",
        ///  "NNNYNN",
        ///  "NNNYNN"}
        /// 1000
        /// Returns: 3000
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var isFriend = new[]{"NNYNNN","NNYNNN","YYNYNN","NNYNYY","NNNYNN","NNNYNN"};
            const int d = 1000;
            var result = _unit.MaxDifference(isFriend, d);
            Assert.IsTrue(result == 3000);
        }

        /// <summary>
        /// {"NNYN",
        ///  "NNNY",
        ///  "YNNN",
        ///  "NYNN"}
        /// 584
        /// Returns: -1
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            var isFriend = new[]{"NNYN","NNNY","YNNN","NYNN"};
            const int d = 584;
            var result = _unit.MaxDifference(isFriend, d);
            Assert.IsTrue(result == -1);
        }

        /// <summary>
        /// {"NYNYYYN",
        ///  "YNNYYYN",
        ///  "NNNNYNN",
        ///  "YYNNYYN",
        ///  "YYYYNNN",
        ///  "YYNYNNY",
        ///  "NNNNNYN"}
        /// 5
        /// Returns: 20
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            var isFriend = new[]{"NYNYYYN","YNNYYYN","NNNNYNN","YYNNYYN","YYYYNNN","YYNYNNY","NNNNNYN"};
            const int d = 5;
            var result = _unit.MaxDifference(isFriend, d);
            Assert.IsTrue(result == 20);
        }

        /// <summary>
        /// {"NYYNNNNYYYYNNNN",
        ///  "YNNNYNNNNNNYYNN",
        ///  "YNNYNYNNNNYNNNN",
        ///  "NNYNNYNNNNNNNNN",
        ///  "NYNNNNYNNYNNNNN",
        ///  "NNYYNNYNNYNNNYN",
        ///  "NNNNYYNNYNNNNNN",
        ///  "YNNNNNNNNNYNNNN",
        ///  "YNNNNNYNNNNNYNN",
        ///  "YNNNYYNNNNNNNNY",
        ///  "YNYNNNNYNNNNNNN",
        ///  "NYNNNNNNNNNNNNY",
        ///  "NYNNNNNNYNNNNYN",
        ///  "NNNNNYNNNNNNYNN",
        ///  "NNNNNNNNNYNYNNN"}
        /// 747
        /// Returns: 2988
        /// </summary>
        [TestMethod]
        public void Test6()
        {
            var isFriend = new[]
                {
                    "NYYNNNNYYYYNNNN", "YNNNYNNNNNNYYNN", "YNNYNYNNNNYNNNN", "NNYNNYNNNNNNNNN", "NYNNNNYNNYNNNNN",
                    "NNYYNNYNNYNNNYN", "NNNNYYNNYNNNNNN", "YNNNNNNNNNYNNNN", "YNNNNNYNNNNNYNN", "YNNNYYNNNNNNNNY",
                    "YNYNNNNYNNNNNNN", "NYNNNNNNNNNNNNY", "NYNNNNNNYNNNNYN", "NNNNNYNNNNNNYNN", "NNNNNNNNNYNYNNN"
                };
            const int d = 747;
            var result = _unit.MaxDifference(isFriend, d);
            Assert.IsTrue(result == 2988);
        }
    }
}
