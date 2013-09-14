using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class DotNotation
    {
        private readonly Code.DotNotation _unit = new Code.DotNotation();

        /// <summary>
        /// "2"
        /// Returns: 1
        /// A single digit by itself has only one interpretation.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            const string dotForm = "2";
            var result = _unit.CountAmbiguity(dotForm);
            Assert.IsTrue(result == 1);
        }

        /// <summary>
        /// "9+5*3"
        /// Returns: 2
        /// This could be read (9+5)*3 or as 9+(5*3). Keep in mind that no order of operations is to be assumed.
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            const string dotForm = "9+5*3";
            var result = _unit.CountAmbiguity(dotForm);
            Assert.IsTrue(result == 2);
        }

        /// <summary>
        /// "9+5.*3"
        /// Returns: 1
        /// Here, the dot prefixed to the * gives it dominance, and this can only be read as (9+5)*3.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            const string dotForm = "9+5.*3";
            var result = _unit.CountAmbiguity(dotForm);
            Assert.IsTrue(result == 1);
        }

        /// <summary>
        /// "1+2.*.3+4"
        /// Returns: 1
        /// The * is dominant here, so this is read as (1+2)*(3+4), and 21 is the only number it can be evaluated to.
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            const string dotForm = "1+2.*.3+4";
            var result = _unit.CountAmbiguity(dotForm);
            Assert.IsTrue(result == 1);
        }

        /// <summary>
        /// "9*8+7*6-5+4*3/2./9"
        /// Returns: 99
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            const string dotForm = "9*8+7*6-5+4*3/2./9";
            var result = _unit.CountAmbiguity(dotForm);
            Assert.IsTrue(result == 99);
        }

        /// <summary>
        /// "1+...2....*.8..+7"
        /// Returns: 0
        /// Notice here how none of the operators in the expression can be dominating. 
        /// Since none of these operators are dominating, none of these operators may be evaluated last, 
        /// meaning that there is no valid interpretation of this expression.
        /// </summary>
        [TestMethod]
        public void Test6()
        {
            const string dotForm = "1+...2....*.8..+7";
            var result = _unit.CountAmbiguity(dotForm);
            Assert.IsTrue(result == 0);
        }
    }
}
