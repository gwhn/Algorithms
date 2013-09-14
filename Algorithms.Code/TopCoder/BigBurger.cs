using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// BigBurger Inc. wants to see if having a single person at the counter both to take orders and to serve them is feasible. 
    /// At each BigBurger, customers will arrive and get in line. 
    /// When they get to the head of the line they will place their order, which will be assembled and served to them. 
    /// Then they will leave the BigBurger and the next person in line will be able to order.
    /// We need to know how long a customer may be forced to wait before he or she can place an order. 
    /// Given a script that lists each customer for a typical day, we want to calculate the maximum customer waiting time. 
    /// Each customer in the script is characterized by an arrival time (measured in minutes after the store opened) 
    /// and a service duration (the number of minutes between ordering and getting the food).
    /// Create a class BigBurger that contains method maxWait that is given a int[] arrival and a int[] service 
    /// describing all the customers and returns the maximum time spent by a customer between arriving and placing the order. 
    /// Corresponding elements of arrival and service refer to the same customer, 
    /// and they are given in the order in which they arrive at the store (arrival is in non-descending order).
    /// If multiple customers arrive at the same time they will all join the line at the same time, 
    /// with the ones listed earlier ahead of ones appearing later in the list.
    /// 
    /// Constraints
    /// arrival will contain between 1 and 50 elements inclusive
    /// service will contain the same number of elements as arrival
    /// the elements of arrival will be in non-decreasing order
    /// each element of arrival will be between 1 and 720 inclusive
    /// each element of service will be between 1 and 15 inclusive
    /// </summary>
    public class BigBurger
    {
        public int MaxWait(int[] arrival, int[] service)
        {
            var max = 0;
            var n = arrival.Length;
            var departure = arrival[0] + service[0];
            for (int i = 1; i < n; i++)
            {
                var wait = 0;
                if (arrival[i] < departure)
                {
                    wait = departure - arrival[i];
                    departure += service[i];
                }
                else
                {
                    departure = arrival[i] + service[i];
                }
                if (wait > max)
                {
                    max = wait;
                }
            }
            return max;
        }
    }
}
