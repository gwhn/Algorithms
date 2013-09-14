using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// If the numbers 1 to 5 are written out in words: one, two, three, four, five, 
    /// then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
    /// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, 
    /// how many letters would be used? 
    /// NOTE: Do not count spaces or hyphens. 
    /// For example, 342 (three hundred and forty-two) contains 23 letters and 
    /// 115 (one hundred and fifteen) contains 20 letters. 
    /// The use of "and" when writing out numbers is in compliance with British usage.
    /// </summary>
    public class NumberLetterCounts
    {
        private const string One = "one";
        private const string Two = "two";
        private const string Three = "three";
        private const string Four = "four";
        private const string Five = "five";
        private const string Six = "six";
        private const string Seven = "seven";
        private const string Eight = "eight";
        private const string Nine = "nine";
        private const string Ten = "ten";
        private const string Eleven = "eleven";
        private const string Twelve = "twelve";
        private const string Thirteen = "thirteen";
        private const string Fourteen = "fourteen";
        private const string Fifteen = "fifteen";
        private const string Sixteen = "sixteen";
        private const string Seventeen = "seventeen";
        private const string Eighteen = "eighteen";
        private const string Nineteen = "nineteen";
        private const string Twenty = "twenty";
        private const string Thirty = "thirty";
        private const string Forty = "forty";
        private const string Fifty = "fifty";
        private const string Sixty = "sixty";
        private const string Seventy = "seventy";
        private const string Eighty = "eighty";
        private const string Ninety = "ninety";
        private const string Hundred = "hundred";
        private const string Thousand = "thousand";
        private const string And = "And";

        public int Solve(int from, int to)
        {
            var sb = new StringBuilder();
            for (int i = from; i <= to; i++)
            {
                var thousands = (i/1000)%10;
                switch (thousands)
                {
                    case 1:
                        sb.Append(One);
                        sb.Append(Thousand);
                        break;
                    case 2:
                        sb.Append(Two);
                        sb.Append(Thousand);
                        break;
                    case 3:
                        sb.Append(Three);
                        sb.Append(Thousand);
                        break;
                    case 4:
                        sb.Append(Four);
                        sb.Append(Thousand);
                        break;
                    case 5:
                        sb.Append(Five);
                        sb.Append(Thousand);
                        break;
                    case 6:
                        sb.Append(Six);
                        sb.Append(Thousand);
                        break;
                    case 7:
                        sb.Append(Seven);
                        sb.Append(Thousand);
                        break;
                    case 8:
                        sb.Append(Eight);
                        sb.Append(Thousand);
                        break;
                    case 9:
                        sb.Append(Nine);
                        sb.Append(Thousand);
                        break;
                }
                var hundreds = (i/100)%10;
                switch (hundreds)
                {
                    case 1:
                        sb.Append(One);
                        sb.Append(Hundred);
                        break;
                    case 2:
                        sb.Append(Two);
                        sb.Append(Hundred);
                        break;
                    case 3:
                        sb.Append(Three);
                        sb.Append(Hundred);
                        break;
                    case 4:
                        sb.Append(Four);
                        sb.Append(Hundred);
                        break;
                    case 5:
                        sb.Append(Five);
                        sb.Append(Hundred);
                        break;
                    case 6:
                        sb.Append(Six);
                        sb.Append(Hundred);
                        break;
                    case 7:
                        sb.Append(Seven);
                        sb.Append(Hundred);
                        break;
                    case 8:
                        sb.Append(Eight);
                        sb.Append(Hundred);
                        break;
                    case 9:
                        sb.Append(Nine);
                        sb.Append(Hundred);
                        break;
                }
                if (hundreds > 0 && i % 100 != 0)
                {
                    sb.Append(And);
                }
                var tens = (i%100)/10;
                switch (tens)
                {
                    case 2:
                        sb.Append(Twenty);
                        break;
                    case 3:
                        sb.Append(Thirty);
                        break;
                    case 4:
                        sb.Append(Forty);
                        break;
                    case 5:
                        sb.Append(Fifty);
                        break;
                    case 6:
                        sb.Append(Sixty);
                        break;
                    case 7:
                        sb.Append(Seventy);
                        break;
                    case 8:
                        sb.Append(Eighty);
                        break;
                    case 9:
                        sb.Append(Ninety);
                        break;                    
                }
                var teens = i%100;
                switch (teens)
                {
                    case 10:
                        sb.Append(Ten);
                        break;
                    case 11:
                        sb.Append(Eleven);
                        break;
                    case 12:
                        sb.Append(Twelve);
                        break;
                    case 13:
                        sb.Append(Thirteen);
                        break;
                    case 14:
                        sb.Append(Fourteen);
                        break;
                    case 15:
                        sb.Append(Fifteen);
                        break;
                    case 16:
                        sb.Append(Sixteen);
                        break;
                    case 17:
                        sb.Append(Seventeen);
                        break;
                    case 18:
                        sb.Append(Eighteen);
                        break;
                    case 19:
                        sb.Append(Nineteen);
                        break;
                }
                if (teens < 10 || teens > 19)
                {
                    var ones = i % 10;
                    switch (ones)
                    {
                        case 1:
                            sb.Append(One);
                            break;
                        case 2:
                            sb.Append(Two);
                            break;
                        case 3:
                            sb.Append(Three);
                            break;
                        case 4:
                            sb.Append(Four);
                            break;
                        case 5:
                            sb.Append(Five);
                            break;
                        case 6:
                            sb.Append(Six);
                            break;
                        case 7:
                            sb.Append(Seven);
                            break;
                        case 8:
                            sb.Append(Eight);
                            break;
                        case 9:
                            sb.Append(Nine);
                            break;
                    }                    
                }
            }
            return sb.ToString().Length;
        }
    }
}
