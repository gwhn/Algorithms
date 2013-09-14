using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class ExerciseMachine
    {
        private readonly Code.ExerciseMachine _unit = new Code.ExerciseMachine();

        /// <summary>
        /// "00:30:00"
        /// Returns: 99
        /// The standard 30 minute workout. Each one percent increment can be displayed every 18 seconds.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const string time = "00:30:00";
            var result = _unit.GetPercentages(time);
            Assert.IsTrue(result == 99);
        }

        /// <summary>
        /// "00:28:00"
        /// Returns: 19
        /// The 28 minute workout. The user completes 5 percent of the workout every 1 minute, 24 seconds.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const string time = "00:28:00";
            var result = _unit.GetPercentages(time);
            Assert.IsTrue(result == 19);
        }

        /// <summary>
        /// "23:59:59"
        /// Returns: 0
        /// This is the longest workout possible, given the constraints. No percentages are ever displayed on the screen.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const string time = "23:59:59";
            var result = _unit.GetPercentages(time);
            Assert.IsTrue(result == 0);
        }

        /// <summary>
        /// "00:14:10"
        /// Returns: 49
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const string time = "00:14:10";
            var result = _unit.GetPercentages(time);
            Assert.IsTrue(result == 49);
        }

        /// <summary>
        /// "00:19:16"
        /// Returns: 3
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const string time = "00:19:16";
            var result = _unit.GetPercentages(time);
            Assert.IsTrue(result == 3);
        }
    }
}
