using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// There is a small cube planet somewhere. On each side of the cube there lives a four-armed dragon. 
    /// It is time for dinner now. Each dragon sits in front of his bowl with food.
    /// During each round, the following happens: Each dragon is trying to steal food from his neighbors 
    /// (living on four neighboring sides of the cube). 
    /// He spreads his four arms there (each arm goes to each separate neighbor). 
    /// As other dragons do the same, four hands meet in each bowl of food. Four hands fight for a while 
    /// and each takes one quarter of the food in this bowl to its own bowl. 
    /// Hence, each round the food distribution changes.
    /// Given the initial amount of food in each bowl and the number of rounds, 
    /// return the amount of food the dragons' boss Snaug will have after these rounds.
    /// In more detail:
    /// The initial amount of food will be given in the following order: front, back, up, down, left, right. 
    /// The dragons' boss Snaug lives on the "up" side of the cube. 
    /// If the answer is an integer, return this integer. 
    /// If the answer is a fraction, return the answer in the format X/Y, where X and Y are integers without common factors. 
    /// Extra leading zeroes shouldn't be present in your answer.
    /// Example.
    /// Suppose that the initial distribution of food is the following: 0, 0, 4, 0, 0, 0. 
    /// That is Snaug has 4 and everybody else has 0 amount of food in their bowls. 
    /// After the first round the distribution of food will be the following: 1, 1, 0, 0, 1, 1, 
    /// that is every neighbor of Snaug steals from him one quarter of his food. 
    /// After the second round the distribution of food will be the following: 1/2, 1/2, 1, 1, 1/2, 1/2.
    /// 
    /// Constraints
    /// initialFood has exactly 6 elements
    /// each element of initialFood is between 0 and 1,000 inclusive
    /// rounds is between 0 and 45 inclusive
    /// </summary>
    public class Dragons
    {
        public String Snaug(int[] initialFood, int rounds)
        {
//            var state = new[]
//                {
//                    new[] {initialFood[0], 1},
//                    new[] {initialFood[1], 1},
//                    new[] {initialFood[2], 1},
//                    new[] {initialFood[3], 1},
//                    new[] {initialFood[4], 1},
//                    new[] {initialFood[5], 1}
//                };
            var state = new[]
                {
                    Convert.ToDouble(initialFood[0]),
                    Convert.ToDouble(initialFood[1]),
                    Convert.ToDouble(initialFood[2]),
                    Convert.ToDouble(initialFood[3]),
                    Convert.ToDouble(initialFood[4]),
                    Convert.ToDouble(initialFood[5])
                };

            const int n = 6;
            var dragons = new int[n][];
            dragons[0] = new[] {2, 3, 4, 5};
            dragons[1] = new[] {2, 3, 4, 5};
            dragons[2] = new[] {0, 1, 4, 5};
            dragons[3] = new[] {0, 1, 4, 5};
            dragons[4] = new[] {0, 1, 2, 3};
            dragons[5] = new[] {0, 1, 2, 3};
            for (var i = 0; i < rounds; i++)
            {
//                var newState = (int[][]) state.Clone();
                var newState = (double[]) state.Clone();
                for (var j = 0; j < n; j++)
                {
                    for (var k = 0; k < dragons[j].Length; k++)
                    {
                        var dragon = dragons[j][k];
//                        var quarter = Multiply(state[dragon], new[]{1,4});
                        var quarter = state[dragon]*0.25D;
//                        newState[dragon] = Subtract(newState[dragon], quarter);                            
                        newState[dragon] -= quarter;
//                        newState[j] = Add(newState[j], quarter);
                        newState[j] += quarter;
                    }
                }
                state = newState;
            }
//            Reduce(state[2]);
//            return state[2][1] == 1
//                       ? state[2][0].ToString(CultureInfo.InvariantCulture)
//                       : string.Format("{0}/{1}", state[2][0], state[2][1]);
            var fraction = ConvertToFraction(state[2]);
            return fraction[1] == 1
                        ? fraction[0].ToString(CultureInfo.InvariantCulture)
                        : string.Format("{0}/{1}", fraction[0], fraction[1]);
        }

        private static int[] ConvertToFraction(double value)
        {
            var s = value.ToString(CultureInfo.InvariantCulture);
            var i = s.IndexOf('.');
            if (i < 0)
            {
                return new[]
                    {
                        Convert.ToInt32(value),
                        1
                    };
            }
            var f = s.Substring(i + 1);
            var l = f.Length;
            var m = Math.Pow(10, l);
            var r = new[]
                {
                    Convert.ToInt32(value*m),
                    Convert.ToInt32(m)
                };
            Reduce(r);
            return r;
        }


        private static int Gcd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return Gcd(b, a%b);
        }

        private static int Lcm(int a, int b)
        {
            return a*b/Gcd(a, b);
        }

        private static int[] Add(int[] a, int[] b)
        {
            if (a[1] == 0)
            {
                return b;
            }
            if (b[1] == 0)
            {
                return a;
            }
            var d = Lcm(a[1], b[1]);
            return new[]
                {
                    d/a[1]*a[0] + d/b[1]*b[0],
                    d
                };
        }

        private static int[] Subtract(int[] a, int[] b)
        {
            if (a[1] == 0)
            {
                return new[] {-b[0], b[1]};
            }
            if (b[1] == 0)
            {
                return a;
            }
            var d = Lcm(a[1], b[1]);
            return new[]
                {
                    d/a[1]*a[0] - d/b[1]*b[0],
                    d
                };
        }

        private static int[] Multiply(int[] a, int[] b)
        {
            return new[]
                {
                    a[0]*b[0], 
                    a[1]*b[1]
                };
        }

        private static void Reduce(int[] a)
        {
            var b = Gcd(a[0], a[1]);
            a[0] /= b;
            a[1] /= b;
        }
    }
}
