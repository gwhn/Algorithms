using System;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public class SmallestMultiple
    {
        public int Find(int n)
        {
            var ok = true;
            var result = n*2;
            do
            {
                ok = true;
                for (int i = n; i > 1; i--)
                {
                    if (result % i != 0)
                    {
                        ok = false;
                        result += n;
                        break;
                    }
                }                
            } while (!ok);
            return result;
        }
    }
}
