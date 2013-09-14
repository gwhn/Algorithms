using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class Trekking
    {
        private readonly Code.Trekking _unit = new Code.Trekking();

        /// <summary>
        /// "^^....^^^..."
        /// {"CwwCwwCwwCww",
        ///  "wwwCwCwwwCww",
        ///  "wwwwCwwwwCww"}
        /// Returns: 2
        /// The first plan is not valid because it involves camping in the first visited location, 
        /// which is not suitable for camping. 
        /// The other two plans are valid, but the third involves only two camps, so it's the best one.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const string trail = "^^....^^^...";
            var plans = new[]{"CwwCwwCwwCww","wwwCwCwwwCww","wwwwCwwwwCww"};
            var result = _unit.FindCamps(trail, plans);
            Assert.IsTrue(result == 2);
        }

        /// <summary>
        /// "^^^^"
        /// {"wwww",
        ///  "wwwC"
        /// }
        /// Returns: 0
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const string trail = "^^^^";
            var plans = new[]{"wwww","wwwC"};
            var result = _unit.FindCamps(trail, plans);
            Assert.IsTrue(result == 0);
        }

        /// <summary>
        /// "^^.^^^^"
        /// {"wwCwwwC",
        ///  "wwwCwww",
        ///  "wCwwwCw"}
        /// Returns: -1
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const string trail = "^^.^^^^";
            var plans = new[]{"wwCwwwC","wwwCwww","wCwwwCw"};
            var result = _unit.FindCamps(trail, plans);
            Assert.IsTrue(result == -1);
        }

        /// <summary>
        /// "^^^^....^.^.^."
        /// {"wwwwCwwwwCwCwC",
        ///  "wwwwCwwCwCwwwC",
        ///  "wwwCwwwCwwwCww",
        ///  "wwwwwCwwwCwwwC"}
        /// Returns: 3
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const string trail = "^^^^....^.^.^.";
            var plans = new[]{"wwwwCwwwwCwCwC","wwwwCwwCwCwwwC","wwwCwwwCwwwCww","wwwwwCwwwCwwwC"};
            var result = _unit.FindCamps(trail, plans);
            Assert.IsTrue(result == 3);
        }

        /// <summary>
        /// ".............."
        /// {"CwCwCwCwCwCwCw",
        ///  "CwwCwwCwwCwwCw"}
        /// Returns: 5
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const string trail = "..............";
            var plans = new[]{"CwCwCwCwCwCwCw","CwwCwwCwwCwwCw"};
            var result = _unit.FindCamps(trail, plans);
            Assert.IsTrue(result == 5);
        }
    }
}
