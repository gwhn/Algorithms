using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// Julius Caesar used a system of cryptography, now known as Caesar Cipher, 
    /// which shifted each letter 2 places further through the alphabet 
    /// (e.g. 'A' shifts to 'C', 'R' shifts to 'T', etc.). 
    /// At the end of the alphabet we wrap around, that is 'Y' shifts to 'A'.
    /// We can, of course, try shifting by any number. 
    /// Given an encoded text and a number of places to shift, decode it.
    /// For example, "TOPCODER" shifted by 2 places will be encoded as "VQREQFGT". 
    /// In other words, if given (quotes for clarity) "VQREQFGT" and 2 as input, 
    /// you will return "TOPCODER". See example 0 below.
    /// 
    /// Constraints
    /// cipherText has between 0 to 50 characters inclusive
    /// each character of cipherText is an uppercase letter 'A'-'Z'
    /// shift is between 0 and 25 inclusive
    /// </summary>
    public class CaesarCipher
    {
        public String Decode(String cipherText, int shift)
        {
            var n = cipherText.Length;
            var result = "";
            for (var i = 0; i < n; i++)
            {
                int a = cipherText[i];
                int b = a - shift;
                if (b < 65)
                {
                    b = b + 26;
                }
                char c = Convert.ToChar(b);
                result += c;
            }
            return result;
        }
    }
}
