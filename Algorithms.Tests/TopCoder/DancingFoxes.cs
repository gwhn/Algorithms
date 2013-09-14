using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class DancingFoxes
    {
        private readonly Code.DancingFoxes _unit = new Code.DancingFoxes();

        /// <summary>
        /// {"NNY",
        ///  "NNY",
        ///  "YYN"}
        /// Returns: 1
        /// There are 3 foxes. Ciel and Jiro are not friends, but they are both friends with fox 2. 
        /// Thus, they may dance together in the first dance and become friends. 
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var friendship = new[]{"NNY","NNY","YYN"};
            var result = _unit.MinimalDays(friendship);
            Assert.IsTrue(result == 1);
        }

        /// <summary>
        /// {"NNNNN",
        ///  "NNYYY",
        ///  "NYNYY",
        ///  "NYYNY",
        ///  "NYYYN"}
        /// Returns: -1
        /// Ciel does not know any other fox at the dance, so she cannot dance with anybody. 
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var friendship = new[]{"NNNNN","NNYYY","NYNYY","NYYNY","NYYYN"};
            var result = _unit.MinimalDays(friendship);
            Assert.IsTrue(result == -1);
        }

        /// <summary>
        /// {"NNYYNN",
        ///  "NNNNYY",
        ///  "YNNNYN",
        ///  "YNNNNY",
        ///  "NYYNNN",
        ///  "NYNYNN"}
        /// Returns: 2
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var friendship = new[] {"NNYYNN","NNNNYY","YNNNYN","YNNNNY","NYYNNN","NYNYNN"};
            var result = _unit.MinimalDays(friendship);
            Assert.IsTrue(result == 2);
        }

        /// <summary>
        /// {"NNYNNNNYN",
        ///  "NNNNYNYNN",
        ///  "YNNYNYNNN",
        ///  "NNYNYNYYN",
        ///  "NYNYNNNNY",
        ///  "NNYNNNYNN",
        ///  "NYNYNYNNN",
        ///  "YNNYNNNNY",
        ///  "NNNNYNNYN"}
        /// Returns: 3
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            var friendship = new[]
                {
                    "NNYNNNNYN", "NNNNYNYNN", "YNNYNYNNN", "NNYNYNYYN", "NYNYNNNNY", "NNYNNNYNN", "NYNYNYNNN", "YNNYNNNNY",
                    "NNNNYNNYN"
                };
            var result = _unit.MinimalDays(friendship);
            Assert.IsTrue(result == 3);
        }

        /// <summary>
        /// {"NY",
        ///  "YN"}
        /// Returns: 0
        /// Ciel and Jiro are already friends in the beginning, no dances are needed. 
        /// In such a case, the correct return value is 0. 
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            var friendship = new[]{"NY","YN"};
            var result = _unit.MinimalDays(friendship);
            Assert.IsTrue(result == 0);
        }
    }
}
