using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class StrengthSchedule
    {
        private readonly Code.ScheduleStrength _unit = new ScheduleStrength();

        /// <summary>
        /// {"BEARS",
        ///  "GIANTS",
        ///  "COWBOYS",
        ///  "BRONCOS",
        ///  "DOLPHINS",
        ///  "LIONS"}
        /// {"-WLWW-",
        ///  "L-WL-W",
        ///  "WL---W",
        ///  "LW--L-",
        ///  "L--W--",
        ///  "-LL---"}
        /// Returns: {"BEARS", "DOLPHINS", "BRONCOS", "COWBOYS", "GIANTS", "LIONS" }
        /// This season's results gives us the following win/loss records:
        ///         wins - losses
        /// BEARS      3 - 1
        /// GIANTS     2 - 2  (1 loss to the BEARS)
        /// COWBOYS    2 - 1  (1 win against the BEARS)
        /// BRONCOS    1 - 2  (1 loss to the BEARS)
        /// DOLPHINS   1 - 1  (1 loss to the BEARS)
        /// LIONS      0 - 2  (did not play the BEARS)
        /// The BEARS's opponents are the GIANTS, COWBOYS, BRONCOS and DOLPHINS. 
        /// Their combined win/loss record is 6-6 (6 wins, 6 losses), 
        /// but when we exclude games played against the BEARS, this record becomes 5-3. 
        /// So, the BEARS have a schedule strength of 5/8 = .625
        /// Here are the cumulative records and winning percentages calculated for each team:
        ///            Record    Winning %
        /// BEARS      5 - 3    5/8 = .625
        /// GIANTS     4 - 4    4/8 = .5
        /// COWBOYS    4 - 3    4/7 = .5714
        /// BRONCOS    4 - 3    4/7 = .5714
        /// DOLPHINS   3 - 2    3/5 = .6
        /// LIONS      2 - 3    2/5 = .4
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var teams = new[] {"BEARS", "GIANTS", "COWBOYS", "BRONCOS", "DOLPHINS", "LIONS"};
            var results = new[] {"-WLWW-", "L-WL-W", "WL---W", "LW--L-", "L--W--", "-LL---"};
            var result = _unit.Calculate(teams, results);
            Assert.IsTrue(result.Length == teams.Length);
            Assert.IsTrue(result[0] == "BEARS");
            Assert.IsTrue(result[1] == "DOLPHINS");
            Assert.IsTrue(result[2] == "BRONCOS");
            Assert.IsTrue(result[3] == "COWBOYS");
            Assert.IsTrue(result[4] == "GIANTS");
            Assert.IsTrue(result[5] == "LIONS");
        }

        /// <summary>
        /// {"BEARS",
        ///  "COWBOYS",
        ///  "GIANTS",
        ///  "PACKERS"}
        /// {"-LLW",
        ///  "W-WW",
        ///  "WL--",
        ///  "LL--"}
        /// Returns: {"GIANTS", "BEARS", "COWBOYS", "PACKERS" }
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var teams = new[]{"BEARS","COWBOYS","GIANTS","PACKERS"};
            var results = new[]{"-LLW","W-WW","WL--","LL--"};
            var result = _unit.Calculate(teams, results);
            Assert.IsTrue(result.Length == teams.Length);
            Assert.IsTrue(result[0] == "GIANTS");
            Assert.IsTrue(result[1] == "BEARS");
            Assert.IsTrue(result[2] == "COWBOYS");
            Assert.IsTrue(result[3] == "PACKERS");
        }

        /// <summary>
        /// {"AZTECS",
        ///  "COUGARS",
        ///  "COWBOYS",
        ///  "FALCONS",
        ///  "HORNEDFROGS",
        ///  "LOBOS",
        ///  "RAMS",
        ///  "REBELS",
        ///  "UTES"}
        /// {"---L-L--W",
        ///  "--LL-LWL-",
        ///  "-W--WWLLW",
        ///  "WW---L--W",
        ///  "--L--W-L-",
        ///  "WWLWL-LW-",
        ///  "-LW--W-L-",
        ///  "-WW-WLW--",
        ///  "L-LL-----"}
        /// Returns: 
        /// {"HORNEDFROGS",
        ///  "COUGARS",
        ///  "RAMS",
        ///  "LOBOS",
        ///  "REBELS",
        ///  "UTES",
        ///  "COWBOYS",
        ///  "AZTECS",
        ///  "FALCONS" }
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var teams = new[]
                {"AZTECS", "COUGARS", "COWBOYS", "FALCONS", "HORNEDFROGS", "LOBOS", "RAMS", "REBELS", "UTES"};
            var results = new[]
                {
                    "---L-L--W", "--LL-LWL-", "-W--WWLLW", "WW---L--W", "--L--W-L-", "WWLWL-LW-", "-LW--W-L-", "-WW-WLW--",
                    "L-LL-----"
                };
            var result = _unit.Calculate(teams, results);
            Assert.IsTrue(result.Length == teams.Length);
            Assert.IsTrue(result[0] == "HORNEDFROGS");
            Assert.IsTrue(result[1] == "COUGARS");
            Assert.IsTrue(result[2] == "RAMS");
            Assert.IsTrue(result[3] == "LOBOS");
            Assert.IsTrue(result[4] == "REBELS");
            Assert.IsTrue(result[5] == "UTES");
            Assert.IsTrue(result[6] == "COWBOYS");
            Assert.IsTrue(result[7] == "AZTECS");
            Assert.IsTrue(result[8] == "FALCONS");
        }

        /// <summary>
        /// {"E", "D", "C", "B", "Z"}
        /// {
        /// "--LLL",
        /// "---LL",
        /// "W---L",
        /// "WW---",
        /// "WWW--"
        /// }
        /// Returns: {"D", "E", "C", "Z", "B" }
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            var teams = new[] { "E", "D", "C", "B", "Z" };
            var results = new[] {"--LLL", "---LL", "W---L", "WW---", "WWW--"};
            var result = _unit.Calculate(teams, results);
            Assert.IsTrue(result.Length == teams.Length);
            Assert.IsTrue(result[0] == "D");
            Assert.IsTrue(result[1] == "E");
            Assert.IsTrue(result[2] == "C");
            Assert.IsTrue(result[3] == "Z");
            Assert.IsTrue(result[4] == "B");
        }
    }
}
