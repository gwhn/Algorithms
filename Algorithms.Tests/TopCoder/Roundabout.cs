using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class Roundabout
    {
        private readonly Code.Roundabout _unit = new Code.Roundabout();

        /// <summary>
        /// "--"
        /// "--"
        /// "WE"
        /// "-S"
        /// Returns: 6
        /// Note for plugin users: this example contains an image. Please view the problem in the applet to see the image.   At the start, a car approaches the roundabout from the South. At time = 1, the car going West enters the roundabout, another car approaches from the South and another one from the West. At time = 2, the car going West moves one position, the car going East must give way, the car going South enters the roundabout. At time = 3, the car going West moves one position, the car going East must still give way, the car going South moves one position. At time = 4, the car going West moves one position, the car going South exits the roundabout, the car going East enters the roundabout. At time = 5, the car going West exits the roundabout, the car going East moves one position. At time = 6, the car going East exits the roundabout. The method should return 6.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const string north = "--";
            const string east = "--";
            const string south = "WE";
            const string west = "-S";
            var result = _unit.ClearUpTime(north, east, south, west);
            Assert.IsTrue(result == 6);
        }

        /// <summary>
        /// "WWW"
        /// "NNN"
        /// "---"
        /// "---"
        /// Returns: 9
        /// All the cars from the North must wait until the cars from the East exit the roundabout. Only then can they enter the roundabout.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const string north = "WWW";
            const string east = "NNN";
            const string south = "---";
            const string west = "---";
            var result = _unit.ClearUpTime(north, east, south, west);
            Assert.IsTrue(result == 9);
        }

        /// <summary>
        /// "SSS"
        /// "WW-"
        /// "N"
        /// "S------"
        /// Returns: 13
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const string north = "SSS";
            const string east = "WW-";
            const string south = "N";
            const string west = "S------";
            var result = _unit.ClearUpTime(north, east, south, west);
            Assert.IsTrue(result == 13);
        }

        /// <summary>
        /// "SSS-"
        /// "--W---W"
        /// "WE"
        /// "-S"
        /// Returns: 14
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const string north = "SSS-";
            const string east = "--W---W";
            const string south = "WE";
            const string west = "-S";
            var result = _unit.ClearUpTime(north, east, south, west);
            Assert.IsTrue(result == 14);
        }

        /// <summary>
        /// "E"
        /// "-N"
        /// "W"
        /// "-S"
        /// Returns: 5
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const string north = "E";
            const string east = "-N";
            const string south = "W";
            const string west = "-S";
            var result = _unit.ClearUpTime(north, east, south, west);
            Assert.IsTrue(result == 5);
        }

        /// <summary>
        /// ""
        /// ""
        /// ""
        /// ""
        /// Returns: 0
        /// </summary>
        [TestMethod]
        public void Test6()
        {
            const string north = "";
            const string east = "";
            const string south = "";
            const string west = "";
            var result = _unit.ClearUpTime(north, east, south, west);
            Assert.IsTrue(result == 0);
        }

        /// <summary>
        /// "W"
        /// ""
        /// "--E"
        /// ""
        /// Returns: 6
        /// Note: At time = 3, the car from the South does not enter the roundabout, because it has already decided not to enter, based on its knowledge from the previous second. Thus it enters at time = 4.
        /// </summary>
        [TestMethod]
        public void Test7()
        {
            const string north = "W";
            const string east = "";
            const string south = "--E";
            const string west = "";
            var result = _unit.ClearUpTime(north, east, south, west);
            Assert.IsTrue(result == 6);
        }

        /// <summary>
        /// "ES"
        /// "N"
        /// "E"
        /// ""
        /// Returns: 9
        /// </summary>
        [TestMethod]
        public void Test8()
        {
            const string north = "";
            const string east = "";
            const string south = "";
            const string west = "";
            var result = _unit.ClearUpTime(north, east, south, west);
            Assert.IsTrue(result == 0);
        }

        /// <summary>
        /// "E"
        /// "SN"
        /// "-N"
        /// "S-E"
        /// Returns: 12
        /// </summary>
        [TestMethod]
        public void Test9()
        {
            const string north = "E";
            const string east = "SN";
            const string south = "-N";
            const string west = "S-E";
            var result = _unit.ClearUpTime(north, east, south, west);
            Assert.IsTrue(result == 12);
        }
    }
}
