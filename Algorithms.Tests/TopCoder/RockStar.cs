using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class RockStar
    {
        private readonly Code.RockStar _unit = new Code.RockStar();

        /// <summary>
        /// 100
        /// 0
        /// 0
        /// 200
        /// Returns: 100
        /// You must begin the album with one of your fast songs by the 3rd restriction. 
        /// By the 1st restriction, each subsequent song must also now start fast. 
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const int ff = 100;
            const int fs = 0;
            const int sf = 0;
            const int ss = 200;
            var result = _unit.GetNumSongs(ff, fs, sf, ss);
            Assert.IsTrue(result == 100);
        }

        /// <summary>
        /// 0
        /// 0
        /// 20
        /// 200
        /// Returns: 201
        /// Since you do not have any songs that start fast, 
        /// you may begin the album with a song that starts slow. You can use 201 songs by first using the 200 songs that start slow and end slow, then finishing the album with one song that starts slow and ends fast. 
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const int ff = 0;
            const int fs = 0;
            const int sf = 20;
            const int ss = 200;
            var result = _unit.GetNumSongs(ff, fs, sf, ss);
            Assert.IsTrue(result == 201);
        }

        /// <summary>
        /// 1
        /// 2
        /// 1
        /// 1
        /// Returns: 5
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const int ff = 1;
            const int fs = 2;
            const int sf = 1;
            const int ss = 1;
            var result = _unit.GetNumSongs(ff, fs, sf, ss);
            Assert.IsTrue(result == 5);
        }

        /// <summary>
        /// 192
        /// 279
        /// 971
        /// 249
        /// Returns: 999
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const int ff = 192;
            const int fs = 279;
            const int sf = 971;
            const int ss = 249;
            var result = _unit.GetNumSongs(ff, fs, sf, ss);
            Assert.IsTrue(result == 999);
        }
    }
}
