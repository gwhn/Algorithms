using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class InsertZ
    {
        private readonly Code.InsertZ _unit = new Code.InsertZ();

        /// <summary>
        /// "fox"
        /// "fozx"
        /// Returns: "Yes"
        /// By inserting 'z' to the position between 'o' and 'x' in "fox", we obtain "fozx".
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const string init = "fox";
            const string goal = "fozx";
            var result = _unit.CanTransform(init, goal);
            Assert.IsTrue(result == "Yes");
        }

        /// <summary>
        /// "fox"
        /// "zfzoxzz"
        /// Returns: "Yes"
        /// You may perform the operation multiple times.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const string init = "fox";
            const string goal = "zfzoxzz";
            var result = _unit.CanTransform(init, goal);
            Assert.IsTrue(result == "Yes");
        }

        /// <summary>
        /// "foon"
        /// "foon"
        /// Returns: "Yes"
        /// In this case init and goal are equal. You do not have to perform the operation.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const string init = "foon";
            const string goal = "foon";
            var result = _unit.CanTransform(init, goal);
            Assert.IsTrue(result == "Yes");
        }

        /// <summary>
        /// "topcoder"
        /// "zopzoder"
        /// Returns: "No"
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const string init = "topcoder";
            const string goal = "zopzoder";
            var result = _unit.CanTransform(init, goal);
            Assert.IsTrue(result == "No");
        }

        /// <summary>
        /// "aaaaaaaaaa"
        /// "a"
        /// Returns: "No"
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const string init = "aaaaaaaaaa";
            const string goal = "a";
            var result = _unit.CanTransform(init, goal);
            Assert.IsTrue(result == "No");
        }

        /// <summary>
        /// "mvixrdnrpxowkasufnvxaq"
        /// "mvizzxzzzrdzznzrpxozzwzzkazzzszzuzzfnvxzzzazzq"
        /// Returns: "Yes"
        /// </summary>
        [TestMethod]
        public void Test6()
        {
            const string init = "mvixrdnrpxowkasufnvxaq";
            const string goal = "mvizzxzzzrdzznzrpxozzwzzkazzzszzuzzfnvxzzzazzq";
            var result = _unit.CanTransform(init, goal);
            Assert.IsTrue(result == "Yes");
        }

        /// <summary>
        /// "opdlfmvuicjsierjowdvnx"
        /// "zzopzdlfmvzuicjzzsizzeijzowvznxzz"
        /// Returns: "No"
        /// </summary>
        [TestMethod]
        public void Test7()
        {
            const string init = "opdlfmvuicjsierjowdvnx";
            const string goal = "zzopzdlfmvzuicjzzsizzeijzowvznxzz";
            var result = _unit.CanTransform(init, goal);
            Assert.IsTrue(result == "No");
        }
    }
}
