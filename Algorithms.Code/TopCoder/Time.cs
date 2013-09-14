namespace Algorithms.Code
{
    /// <summary>
    ///     Computers tend to store dates and times as single numbers which represent the number of seconds or milliseconds since a particular date.
    ///     Your task in this problem is to write a method whatTime, which takes an int, seconds, representing the number of seconds since midnight
    ///     on some day, and returns a String formatted as "&lt;H&gt;:&lt;M&gt;:&lt;S&gt;". Here, &lt;H&gt; represents the number of complete hours
    ///     since midnight, &lt;M&gt; represents the number of complete minutes since the last complete hour ended, and &lt;S&gt; represents the
    ///     number of seconds since the last complete minute ended. Each of &lt;H&gt;, &lt;M&gt;, and &lt;S&gt; should be an integer, with no extra
    ///     leading 0's. Thus, if seconds is 0, you should return "0:0:0", while if seconds is 3661, you should return "1:1:1".
    ///     Constraints
    ///     seconds will be between 0 and 24*60*60 - 1 = 86399, inclusive.
    /// </summary>
    public class Time
    {
        public string WhatTime(int seconds)
        {
            const int sim = 60;
            const int sih = sim*sim;
            int h = seconds/sih;
            int r = seconds%sih;
            int m = r/sim;
            int s = r%sim;
            return string.Format("{0}:{1}:{2}", h, m, s);
        }
    }
}