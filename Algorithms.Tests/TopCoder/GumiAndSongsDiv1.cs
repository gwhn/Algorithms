using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class GumiAndSongsDiv1
    {
        private readonly Code.GumiAndSongsDiv1 _unit = new Code.GumiAndSongsDiv1();

        /// <summary>
        /// {3, 5, 4, 11}
        /// {2, 1, 3, 1}
        /// 17
        /// Returns: 3
        /// There are four songs. 
        /// Two songs have tone 1 and their durations are 5 and 11, respectively. 
        /// One song has tone 2 and its duration is 3. 
        /// One song has tone 3 and its duration is 4. 
        /// Gumi has 17 units of time to sing. 
        /// It is impossible for Gumi to sing all four songs she knows within the given time: 
        ///     even without the breaks the total length of all songs exceeds 17. 
        /// Here is one way how she can sing three songs: 
        ///     First, she sings song 0 in 3 units of time. 
        ///     Second, she waits for |2-3|=1 unit of time and then sings song 2 in 4 units of time. 
        ///     Finally, she waits for |3-1|=2 units of time and then sings song 1 in 5 units of time. 
        /// The total time spent is 3+1+4+2+5 = 15 units of time.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var duration = new[] { 3, 5, 4, 11 };
            var tone = new[] { 2, 1, 3, 1 };
            const int T = 17;
            var result = _unit.MaxSongs(duration, tone, T);
            Assert.IsTrue(result == 3);
        }

        /// <summary>
        /// {100, 200, 300}
        /// {1, 2, 3}
        /// 99
        /// Returns: 0
        /// In this case, T is so small that she can't sing at all.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var duration = new[] { 100, 200, 300 };
            var tone = new[] { 1, 2, 3 };
            const int T = 99;
            var result = _unit.MaxSongs(duration, tone, T);
            Assert.IsTrue(result == 0);
        }

        /// <summary>
        /// {1, 2, 3, 4}
        /// {1, 1, 1, 1}
        /// 100
        /// Returns: 4
        /// There is plenty of time, so she can sing all of 4 songs.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var duration = new[] { 1, 2, 3, 4 };
            var tone = new[] { 1, 1, 1, 1 };
            const int T = 100;
            var result = _unit.MaxSongs(duration, tone, T);
            Assert.IsTrue(result == 4);
        }

        /// <summary>
        /// {9, 11, 13, 17}
        /// {2, 1, 3, 4}
        /// 20
        /// Returns: 1
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            var duration = new[] { 9, 11, 13, 17 };
            var tone = new[] { 2, 1, 3, 4 };
            const int T = 20;
            var result = _unit.MaxSongs(duration, tone, T);
            Assert.IsTrue(result == 1);
        }

        /// <summary>
        /// {87,21,20,73,97,57,12,80,86,97,98,85,41,12,89,15,41,17,68,37,21,1,9,65,4,
        ///  67,38,91,46,82,7,98,21,70,99,41,21,65,11,1,8,12,77,62,52,69,56,33,98,97}
        /// {88,27,89,2,96,32,4,93,89,50,58,70,15,48,31,2,27,20,31,3,23,86,69,12,59,
        ///  61,85,67,77,34,29,3,75,42,50,37,56,45,51,68,89,17,4,47,9,14,29,59,43,3}
        /// 212
        /// Returns: 12
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            var duration = new[]
                {
                    87, 21, 20, 73, 97, 57, 12, 80, 86, 97, 98, 85, 41, 12, 89, 15, 41, 17, 68, 37, 21, 1, 9, 65, 4, 67, 38
                    , 91, 46, 82, 7, 98, 21, 70, 99, 41, 21, 65, 11, 1, 8, 12, 77, 62, 52, 69, 56, 33, 98, 97
                };
            var tone = new[]
                {
                    88, 27, 89, 2, 96, 32, 4, 93, 89, 50, 58, 70, 15, 48, 31, 2, 27, 20, 31, 3, 23, 86, 69, 12, 59, 61, 85,
                    67, 77, 34, 29, 3, 75, 42, 50, 37, 56, 45, 51, 68, 89, 17, 4, 47, 9, 14, 29, 59, 43, 3
                };
            const int T = 212;
            var result = _unit.MaxSongs(duration, tone, T);
            Assert.IsTrue(result == 12);
        }
    }
}
