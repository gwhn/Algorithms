using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class ImageDithering
    {
        private readonly Code.ImageDithering _unit = new Code.ImageDithering();

        /// <summary>
        /// "BW"
        /// {"AAAAAAAA",
        ///  "ABWBWBWA",
        ///  "AWBWBWBA",
        ///  "ABWBWBWA",
        ///  "AWBWBWBA",
        ///  "AAAAAAAA"}
        /// Returns: 24
        /// Here, our dithered color could consist of black (B) and white (W) pixels, composing a shade of gray. 
        /// In the picture, there is a dithered gray square surrounded by another color (A).
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const string dithered = "BW";
            var screen = new[] {"AAAAAAAA", "ABWBWBWA", "AWBWBWBA", "ABWBWBWA", "AWBWBWBA", "AAAAAAAA"};
            var result = _unit.Count(dithered, screen);
            Assert.IsTrue(result == 24);
        }

        /// <summary>
        /// "BW"
        /// {"BBBBBBBB",
        ///  "BBWBWBWB",
        ///  "BWBWBWBB",
        ///  "BBWBWBWB",
        ///  "BWBWBWBB",
        ///  "BBBBBBBB"}
        /// Returns: 48
        /// Here is the same picture, but with the outer color replaced with black pixels. 
        /// Although in reality, the outer pixels do not form a dithered color, 
        /// your algorithm should still assume they are part of the dithered pattern.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const string dithered = "BW";
            var screen = new[] {"BBBBBBBB", "BBWBWBWB", "BWBWBWBB", "BBWBWBWB", "BWBWBWBB", "BBBBBBBB"};
            var result = _unit.Count(dithered, screen);
            Assert.IsTrue(result == 48);
        }

        /// <summary>
        /// "ACEGIKMOQSUWY"
        /// {"ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX",
        ///  "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX",
        ///  "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX",
        ///  "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX",
        ///  "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX",
        ///  "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX"}
        /// Returns: 150
        /// A picture of vertical stripes, every other stripe is considered part of the dithered color.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const string dithered = "ACEGIKMOQSUWY";
            var screen = new[]
                {
                    "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX",
                    "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX",
                    "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX",
                    "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX",
                    "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX",
                    "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX"
                };
            var result = _unit.Count(dithered, screen);
            Assert.IsTrue(result == 150);
        }

        /// <summary>
        /// "CA"
        /// {"BBBBBBB",
        ///  "BBBBBBB",
        ///  "BBBBBBB"}
        /// Returns: 0
        /// The dithered color is not present.
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const string dithered = "CA";
            var screen = new[] {"BBBBBBB", "BBBBBBB", "BBBBBBB"};
            var result = _unit.Count(dithered, screen);
            Assert.IsTrue(result == 0);
        }

        /// <summary>
        /// "DCBA"
        /// {"ACBD"}
        /// Returns: 4
        /// The order of the colors doesn't matter.
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const string dithered = "DCBA";
            var screen = new[] {"ACBD"};
            var result = _unit.Count(dithered, screen);
            Assert.IsTrue(result == 4);
        }
    }
}
