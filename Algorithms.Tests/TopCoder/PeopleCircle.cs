using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class PeopleCircle
    {
        private readonly Code.PeopleCircle _unit = new Code.PeopleCircle();

        /// <summary>
        /// 5
        /// 3
        /// 2
        /// Returns: "MFMFMFMM"
        /// Return "MFMFMFMM". On the first round you remove the second person - "M_MFMFMM". 
        /// Your new circle looks like "MFMFMMM" from your new starting point. 
        /// Then you remove the second person again etc.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int numMales = 5;
            const int numFemales = 3;
            const int k = 2; 
            var result = _unit.Order(numMales, numFemales, k);
            Assert.IsTrue(result == "MFMFMFMM");
        }

        /// <summary>
        /// 7
        /// 3
        /// 1
        /// Returns: "FFFMMMMMMM"
        /// Starting from the starting point you remove the first person, 
        /// then you continue and remove the next first person etc. 
        /// Clearly, all the females are located at the beginning. Hence return "FFFMMMMMMM"
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int numMales = 7;
            const int numFemales = 3;
            const int k = 1;
            var result = _unit.Order(numMales, numFemales, k);
            Assert.IsTrue(result == "FFFMMMMMMM");
        }

        /// <summary>
        /// 25
        /// 25
        /// 1000
        /// Returns: "MMMMMFFFFFFMFMFMMMFFMFFFFFFFFFMMMMMMMFFMFMMMFMFMMF"
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int numMales = 25;
            const int numFemales = 25;
            const int k = 1000;
            var result = _unit.Order(numMales, numFemales, k);
            Assert.IsTrue(result == "MMMMMFFFFFFMFMFMMMFFMFFFFFFFFFMMMMMMMFFMFMMMFMFMMF");
        }

        /// <summary>
        /// 5
        /// 5
        /// 3
        /// Returns: "MFFMMFFMFM"
        /// Here we mark the removed people with '_', and the starting position with lower-case:
        /// Number of      | People Remaining
        /// Rounds         | (in initial order)
        /// ---------------+-----------------
        ///  0             | mFFMMFFMFM
        ///  1             | MF_mMFFMFM
        ///  2             | MF_MM_fMFM
        ///  3             | MF_MM_FM_m
        ///  4             | M__mM_FM_M
        ///  5             | M__MM__m_M
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const int numMales = 5;
            const int numFemales = 5;
            const int k = 3;
            var result = _unit.Order(numMales, numFemales, k);
            Assert.IsTrue(result == "MFFMMFFMFM");
        }

        /// <summary>
        /// 1
        /// 0
        /// 245
        /// Returns: "M"
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const int numMales = 1;
            const int numFemales = 0;
            const int k = 245;
            var result = _unit.Order(numMales, numFemales, k);
            Assert.IsTrue(result == "M");
        }
    }
}
