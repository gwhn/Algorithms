using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class VendingMachine
    {
        private readonly Code.VendingMachine _unit = new Code.VendingMachine();

        /// <summary>
        /// {"100 100 100"}
        /// {"0,0:0", "0,2:5", "0,1:10"}
        /// Returns: 4
        /// The vending machine has three columns, and only one row. 
        /// Since all three items are the same price, they are all the most expensive, and therefore, the lowest numbered column is rotated to. 
        /// Since the machine starts out at column 0, no rotation is performed before the first purchase. 
        /// The starting configuration is (*'s denote the currently displayed column):
        /// +-----+-----+-----+
        /// | 100 | 100 | 100 |
        /// +*****+-----+-----+
        /// In the first purchase, the customer does not rotate the cylinder because the item he wants is already displayed. 
        /// The configuration of the vending machine is now:
        /// +-----+-----+-----+
        /// |  0  | 100 | 100 |
        /// +*****+-----+-----+
        /// Since the next purchase is at least 5 minutes away, the machine performs a rotation to the most expensive column. 
        /// Both column 1 and 2 are now 100 apiece, so it rotates to the smallest index of these, column 1. 
        /// The fastest way there is to rotate forward 1 column, yielding 1 second of motor use:
        /// +-----+-----+-----+
        /// |  0  | 100 | 100 |
        /// +-----+*****+-----+
        /// The next customer purchases the item in column 2, which is 1 column away, so add 1 second to the motor use. 
        /// Because another 5 minutes passes, the most expensive column is displayed, which is now column 1. 
        /// Add 1 more second for the rotation. 
        /// The configuration is now:
        /// +-----+-----+-----+
        /// |  0  | 100 |  0  |
        /// +-----+*****+-----+
        /// The final customer purchases from column 1, (which is already displayed), and the final most expensive column is rotated to. 
        /// Since all columns are the same price again (0), column 0 is displayed. 
        /// It takes 1 second to get back there, so add 1 more second.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            var prices = new[] {"100 100 100"};
            var purchases = new[] {"0,0:0", "0,2:5", "0,1:10"};
            var result = _unit.MotorUse(prices, purchases);
            Assert.IsTrue(result == 4);
        }

        /// <summary>
        /// {"100 200 300 400 500 600"}
        /// {"0,2:0", "0,3:5", "0,1:10", "0,4:15"}
        /// Returns: 17
        /// The most expensive column during this whole example is column 5. 
        /// Since all purchases are at least 5 minutes apart, 
        /// the most expensive column is rotated to each time.
        /// Before the purchases start, add 1 second for rotating to column 5. 
        /// The first purchase is 3 columns away, so add 3 seconds to get there, 
        /// and 3 seconds to get back to column 5.
        /// The second purchase is 2 columns away, so add 4 seconds to get there and back. 
        /// The third purchase is also 2 columns away, so add 4 more seconds. 
        /// The final purchase is only one column away, so add 2 more seconds.
        /// The final configuration is:
        /// +-----+-----+-----+-----+-----+-----+
        /// | 100 |  0  |  0  |  0  |  0  | 600 |
        /// +-----+-----+-----+-----+-----+*****+
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            var prices = new[] {"100 200 300 400 500 600"};
            var purchases = new[] {"0,2:0", "0,3:5", "0,1:10", "0,4:15"};
            var result = _unit.MotorUse(prices, purchases);
            Assert.IsTrue(result == 17);
        }

        /// <summary>
        /// {"100 200 300 400 500 600"}
        /// {"0,2:0", "0,3:4", "0,1:8", "0,4:12"}
        /// Returns: 11
        /// This is the same as example 1, except now, the purchases are all less than 5 minutes apart.
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            var prices = new[] {"100 200 300 400 500 600"};
            var purchases = new[] {"0,2:0", "0,3:4", "0,1:8", "0,4:12"};
            var result = _unit.MotorUse(prices, purchases);
            Assert.IsTrue(result == 11);
        }

        /// <summary>
        /// {"100 100 100"}
        /// {"0,0:10", "0,0:11"}
        /// Returns: -1
        /// The second purchase is illegal since the item was already purchased
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            var prices = new[] {"100 100 100"};
            var purchases = new[] {"0,0:10", "0,0:11"};
            var result = _unit.MotorUse(prices, purchases);
            Assert.IsTrue(result == -1);
        }

        /// <summary>
        /// {"100 200 300",
        ///  "600 500 400"}
        /// {"0,0:0", "1,1:10", "1,2:20",
        ///  "0,1:21", "1,0:22", "0,2:35"}
        /// Returns: 6
        /// A two-row example. The configurations just before each purchase are:
        /// purchase 1:
        /// +-----+-----+-----+
        /// | 100 | 200 | 300 |
        /// +-----+-----+-----+
        /// | 600 | 500 | 400 |
        /// +*****+-----+-----+
        /// 
        /// purchase 2:
        /// +-----+-----+-----+
        /// |  0  | 200 | 300 |
        /// +-----+-----+-----+
        /// | 600 | 500 | 400 |
        /// +-----+*****+-----+
        /// 
        /// purchase 3:
        /// +-----+-----+-----+
        /// |  0  | 200 | 300 |
        /// +-----+-----+-----+
        /// | 600 |  0  | 400 |
        /// +-----+-----+*****+
        /// 
        /// purchase 4:
        /// +-----+-----+-----+
        /// |  0  | 200 | 300 |
        /// +-----+-----+-----+
        /// | 600 |  0  |  0  |
        /// +-----+-----+*****+
        /// 
        /// purchase 5:
        /// +-----+-----+-----+
        /// |  0  |  0  | 300 |
        /// +-----+-----+-----+
        /// | 600 |  0  |  0  |
        /// +-----+*****+-----+
        /// 
        /// purchase 6:
        /// +-----+-----+-----+
        /// |  0  |  0  | 300 |
        /// +-----+-----+-----+
        /// |  0  |  0  |  0  |
        /// +-----+-----+*****+
        /// 
        /// final:
        /// +-----+-----+-----+
        /// |  0  |  0  |  0  |
        /// +-----+-----+-----+
        /// |  0  |  0  |  0  |
        /// +*****+-----+-----+
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            var prices = new[] {"100 200 300", "600 500 400"};
            var purchases = new[] {"0,0:0", "1,1:10", "1,2:20", "0,1:21", "1,0:22", "0,2:35"};
            var result = _unit.MotorUse(prices, purchases);
            Assert.IsTrue(result == 6);
        }
    }
}