using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// Your friend's birthday is approaching, and he wants his age to be written in candles on his cake. 
    /// In fact, he has already placed several candles on the cake. 
    /// The candles are arranged in a single row, and there are two different colors of candles. 
    /// One color represents the digit '0' and the other color represents the digit '1'. 
    /// You don't want to relayout the candles from scratch, 
    /// so you have to determine if there's a base for which the existing candles spell out your friend's age. 
    /// To simplify the task, you can choose any strictly positive base, not necessarily an integer one.  
    /// For example, if the candles are "00010" and your friend's age is 10, 
    /// then the candles spell out 10 in base 10 (decimal). 
    /// If the candles are "10101" and your friend's age is 21, 
    /// then you can say that "10101" is 21 in base 2 (binary). 
    /// If the candles are "10100" and your friend's age is 6, 
    /// then the candles spell out 6 in base sqrt(2)=1.41421356237.... 
    /// Note that you are not allowed to rotate the cake, so "10" cannot be read as "01".  
    /// You are given a String candlesLine, where the i-th character is the digit ('0' or '1') 
    /// represented by the i-th candle in the row of candles on the cake. 
    /// You are also given an int age, which is your friend's age. 
    /// Return the positive base for which the candles represent your friend's age. 
    /// If there is no such base, return -1, and if there are multiple such bases, return -2.
    /// 
    /// Notes
    /// The number anan-1...a1a0 in base B is equal to an*Bn + an-1*Bn-1 + ... + a1*B + a0.
    /// The returned value must have an absolute or relative error less than 1e-9.
    /// 
    /// Constraints
    /// age will be between 1 and 100, inclusive.
    /// candlesLine will contain between 1 and 50 characters, inclusive.
    /// Each character in candlesLine will be '0' (zero) or '1' (one).
    /// </summary>
    public class AgeEncoding
    {
        public double GetRadix(int age, string candlesLine)
        {

            double minbase = 0;
            double maxbase = 100;
            if (Calc(candlesLine, 1) == age && Calc(candlesLine, 2) == age) return -2;
            if (age == 1 && Calc(candlesLine, 0) == 1 && Calc(candlesLine, 1) != 1) return -1;
            double ret = 0;
            for (int i = 0; i < 100; i++)
            {
                double b = (maxbase + minbase) / 2;
                ret = Calc(candlesLine, b);
                if (ret > age)
                {
                    maxbase = b;
                }
                else
                {
                    minbase = b;
                }
            }
            if (Math.Abs(ret - age) < 1e-9) return maxbase;
            return -1;
        }

        private static double Calc(string candles, double b)
        {
            double ret = 0;
            double mult = 1;
            for (int i = candles.Length - 1; i >= 0; i--)
            {
                if (candles[i] == '1') ret += mult;
                mult *= b;
            }
            return ret;
        }
    }
}
