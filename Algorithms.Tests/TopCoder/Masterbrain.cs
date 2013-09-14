using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class Masterbrain
    {
        private readonly Code.Masterbrain _unit = new Code.Masterbrain();

        /// <summary>
        ///     {"1575"}
        ///     {"4b 0w"}
        ///     Returns: 2400
        ///     If the result was true, we would conclude that 1575 is the only possible combination. 
        ///     However, we know that the second player must lie exactly once, 
        ///     thus we know that 1575 is the only combination NOT possible. 
        ///     Since there are 7^4 = 2401 total combinations, the method should return 2401-1 = 2400.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var guesses = new[] {"1575"};
            var results = new[] {"4b 0w"};
            int result = _unit.PossibleSecrets(guesses, results);
            Assert.IsTrue(result == 2400);
        }

        /// <summary>
        ///     {"1234"}
        ///     {"0b 4w"}
        ///     Returns: 2392
        ///     If the result was true then the set of secret combinations would have 9 elements: 
        ///     {2143, 2341, 2413, 3142, 3412, 3421, 4123, 4312, 4321}. 
        ///     But since the result is false, we must subtract this number from the total. 
        ///     The method should return 2401-9 = 2392.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var guesses = new[] {"1234"};
            var results = new[] {"0b 4w"};
            int result = _unit.PossibleSecrets(guesses, results);
            Assert.IsTrue(result == 2392);
        }

        /// <summary>
        ///     {"6172","6162","3617"}
        ///     {"3b 0w","2b 1w","0b 3w"}
        ///     Returns: 14
        ///     If all results were true, then the secret must be 6176. 
        ///     If the first result is false then the set of secret combinations is 
        ///     {1362, 1762, 2163, 6123, 6136, 6176, 6361, 6761, 7166}. 
        ///     If the second result is false then set is {6132, 6171, 6174, 6175, 6176, 6372}. 
        ///     Finally, if the third result is false then the set is {6176, 6672}. 
        ///     Thus the method should return (9-1)+(6-1)+(2-1) = 14.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var guesses = new[] {"6172", "6162", "3617"};
            var results = new[] {"3b 0w", "2b 1w", "0b 3w"};
            int result = _unit.PossibleSecrets(guesses, results);
            Assert.IsTrue(result == 14);
        }

        /// <summary>
        ///     {"1513","5654","4564","1377","1671","1342"}
        ///     {"1b 0w","0b 1w","1b 0w","1b 0w","0b 1w","0b 1w"}
        ///     Returns: 6
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            var guesses = new[] {"1513", "5654", "4564", "1377", "1671", "1342"};
            var results = new[] {"1b 0w", "0b 1w", "1b 0w", "1b 0w", "0b 1w", "0b 1w"};
            int result = _unit.PossibleSecrets(guesses, results);
            Assert.IsTrue(result == 6);
        }

        /// <summary>
        ///     {"2611", "1371", "7417", "2647", "3735", "4272", "2442", "3443", "1252", "3353"}
        ///     {"0b 2w","0b 2w","0b 1w","0b 2w","1b 0w","1b 0w","1b 0w","0b 1w","1b 1w","0b 1w"}
        ///     Returns: 1
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            var guesses = new[] {"2611", "1371", "7417", "2647", "3735", "4272", "2442", "3443", "1252", "3353"};
            var results = new[]
                {"0b 2w", "0b 2w", "0b 1w", "0b 2w", "1b 0w", "1b 0w", "1b 0w", "0b 1w", "1b 1w", "0b 1w"};
            int result = _unit.PossibleSecrets(guesses, results);
            Assert.IsTrue(result == 1);
        }
    }
}