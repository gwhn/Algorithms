using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class MessageMess
    {
        private readonly Code.MessageMess _unit = new Code.MessageMess();

        /// <summary>
        /// {"HI", "YOU", "SAY"}
        /// "HIYOUSAYHI"
        /// Returns: "HI YOU SAY HI"
        /// A word from dictionary may appear multiple times in the message.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            string[] dictionary = new string[] { "HI", "YOU", "SAY" };
            const string message = "HIYOUSAYHI";
            var result = _unit.Restore(dictionary, message);
            Assert.IsTrue(result == "HI YOU SAY HI");
        }

        /// <summary>
        /// {"ABC", "BCD", "CD", "ABCB"}
        /// "ABCBCD"
        /// Returns: "AMBIGUOUS!"
        /// "ABC BCD" and "ABCB CD" are both possible interpretations of message.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            string[] dictionary = new string[] { "ABC", "BCD", "CD", "ABCB" };
            const string message = "ABCBCD";
            var result = _unit.Restore(dictionary, message);
            Assert.IsTrue(result == "AMBIGUOUS!");
        }

        /// <summary>
        /// {"IMPOSS", "SIBLE", "S"}
        /// "IMPOSSIBLE"
        /// Returns: "IMPOSSIBLE!"
        /// There is no way to concatenate words from this dictionary to form "IMPOSSIBLE"
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            string[] dictionary = new string[] { "IMPOSS", "SIBLE", "S" };
            const string message = "IMPOSSIBLE";
            var result = _unit.Restore(dictionary, message);
            Assert.IsTrue(result == "IMPOSSIBLE!");
        }

        /// <summary>
        /// {"IMPOSS", "SIBLE", "S", "IMPOSSIBLE"}
        /// "IMPOSSIBLE"
        /// Returns: "IMPOSSIBLE"
        /// This message can be decoded without ambiguity. 
        /// This requires the insertion of no spaces since the entire message appears as a word in the dictionary.
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            string[] dictionary = new string[] { "IMPOSS", "SIBLE", "S", "IMPOSSIBLE" };
            const string message = "IMPOSSIBLE";
            var result = _unit.Restore(dictionary, message);
            Assert.IsTrue(result == "IMPOSSIBLE");
        }
    }
}
