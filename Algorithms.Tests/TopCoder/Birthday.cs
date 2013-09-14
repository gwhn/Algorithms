using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class Birthday
    {
        private readonly Code.Birthday _unit = new Code.Birthday();

        /// <summary>
        /// "06/17"
        /// {"02/17 Wernie", "10/12 Stefan"}
        /// Returns: "10/12"
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const string date = "06/17";
            var birthdays = new[] { "02/17 Wernie", "10/12 Stefan" };
            var result = _unit.GetNext(date, birthdays);
            Assert.IsTrue(result == "10/12");
        }

        /// <summary>
        /// "06/17"
        /// {"10/12 Stefan"}
        /// Returns: "10/12"
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const string date = "06/17";
            var birthdays = new[] { "10/12 Stefan" };
            var result = _unit.GetNext(date, birthdays);
            Assert.IsTrue(result == "10/12");
        }

        /// <summary>
        /// "02/17"
        /// {"02/17 Wernie", "10/12 Stefan"}
        /// Returns: "02/17"
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const string date = "02/17";
            var birthdays = new[] { "02/17 Wernie", "10/12 Stefan" };
            var result = _unit.GetNext(date, birthdays);
            Assert.IsTrue(result == "02/17");
        }

        /// <summary>
        /// "12/24"
        /// {"10/12 Stefan"}
        /// Returns: "10/12"
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const string date = "12/24";
            var birthdays = new[] { "10/12 Stefan" };
            var result = _unit.GetNext(date, birthdays);
            Assert.IsTrue(result == "10/12");
        }

        /// <summary>
        /// "01/02"
        /// {"02/17 Wernie",
        ///  "10/12 Stefan",
        ///  "02/17 MichaelJordan",
        ///  "10/12 LucianoPavarotti",
        ///  "05/18 WilhelmSteinitz"}
        /// Returns: "02/17"
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const string date = "01/02";
            var birthdays = new[]
                {
                    "02/17 Wernie", 
                    "10/12 Stefan",
                    "02/17 MichaelJordan",
                    "10/12 LucianoPavarotti",
                    "05/18 WilhelmSteinitz"
                };
            var result = _unit.GetNext(date, birthdays);
            Assert.IsTrue(result == "02/17");
        }
    }
}
