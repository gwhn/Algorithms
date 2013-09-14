using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class PlayGame
    {
        private readonly Code.PlayGame _unit = new Code.PlayGame();

        /// <summary>
        /// {5, 15, 100, 1, 5}
        /// {5, 15, 100, 1, 5}
        /// Returns: 120
        /// Your units with strengths of 100 and 15, along with one of your strength 5 units, can avoid capture. 
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var you = new[] { 5, 15, 100, 1, 5 };
            var computer = new[] { 5, 15, 100, 1, 5 };
            var result = _unit.SaveCreatures(you, computer);
            Assert.IsTrue(result == 120);
        }

        /// <summary>
        /// {1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 
        ///  1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000,
        ///  1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000,
        ///  1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000,
        ///  1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000}
        /// {1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 
        ///  1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000,
        ///  1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000,
        ///  1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000,
        ///  1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000}
        /// Returns: 0
        /// All units are equally strong, so all your units are captured. 
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var you = new[]
                {
                    1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000,
                    1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000
                    , 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000
                };
            var computer = new[]
                {
                    1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000,
                    1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000
                    , 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000
                };
            var result = _unit.SaveCreatures(you, computer);
            Assert.IsTrue(result == 0);
        }

        /// <summary>
        /// {1, 3, 5, 7, 9, 11, 13, 15, 17, 19}
        /// {2, 4, 6, 8, 10, 12, 14, 16, 18, 20}
        /// Returns: 99
        /// You assign your weakest unit to the computer's strongest unit. Then you assign all your other units in such a way that each of your units has a strength one higher than the opposing unit. So all your units except the weakest one avoid capture. 
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var you = new[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            var computer = new[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            var result = _unit.SaveCreatures(you, computer);
            Assert.IsTrue(result == 99);
        }

        /// <summary>
        /// {2, 3, 4, 5, 6, 7, 8, 9, 10, 11}
        /// {10, 9, 8, 7, 6, 5, 4, 3, 2, 1}
        /// Returns: 65
        /// All your units can win. 
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            var you = new[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var computer = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var result = _unit.SaveCreatures(you, computer);
            Assert.IsTrue(result == 65);
        }

        /// <summary>
        /// {651, 321, 106, 503, 227, 290, 915, 549, 660, 115,
        ///  491, 378, 495, 789, 507, 381, 685, 530, 603, 394,
        ///  7, 704, 101, 620, 859, 490, 744, 495, 379, 781,
        ///  550, 356, 950, 628, 177, 373, 132, 740, 946, 609,
        ///  29, 329, 57, 636, 132, 843, 860, 594, 718, 849}
        /// {16, 127, 704, 614, 218, 67, 169, 621, 340, 319,
        ///  366, 658, 798, 803, 524, 608, 794, 896, 145, 627,
        ///  401, 253, 137, 851, 67, 426, 571, 302, 546, 225,
        ///  311, 111, 804, 135, 284, 784, 890, 786, 740, 612,
        ///  360, 852, 228, 859, 229, 249, 540, 979, 55, 82}
        /// Returns: 25084
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            var you = new[]
                {
                    651, 321, 106, 503, 227, 290, 915, 549, 660, 115, 491, 378, 495, 789, 507, 381, 685, 530, 603, 394, 7,
                    704, 101, 620, 859, 490, 744, 495, 379, 781, 550, 356, 950, 628, 177, 373, 132, 740, 946, 609, 29,
                    329, 57, 636, 132, 843, 860, 594, 718, 849
                };
            var computer = new[]
                {
                    16, 127, 704, 614, 218, 67, 169, 621, 340, 319, 366, 658, 798, 803, 524, 608, 794, 896, 145, 627, 401,
                    253, 137, 851, 67, 426, 571, 302, 546, 225, 311, 111, 804, 135, 284, 784, 890, 786, 740, 612, 360,
                    852, 228, 859, 229, 249, 540, 979, 55, 82
                };
            var result = _unit.SaveCreatures(you, computer);
            Assert.IsTrue(result == 25084);
        }
    }
}
