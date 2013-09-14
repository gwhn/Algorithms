using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// Let's say you have a binary string such as the following:
    /// 011100011
    /// One way to encrypt this string is to add to each digit the sum of its adjacent digits. 
    /// For example, the above string would become:
    /// 123210122
    /// In particular, if P is the original string, and Q is the encrypted string, then Q[i] = P[i-1] + P[i] + P[i+1] for all digit positions i. 
    /// Characters off the left and right edges of the string are treated as zeroes.
    /// An encrypted string given to you in this format can be decoded as follows (using 123210122 as an example):
    /// Assume P[0] = 0.
    /// Because Q[0] = P[0] + P[1] = 0 + P[1] = 1, we know that P[1] = 1.
    /// Because Q[1] = P[0] + P[1] + P[2] = 0 + 1 + P[2] = 2, we know that P[2] = 1.
    /// Because Q[2] = P[1] + P[2] + P[3] = 1 + 1 + P[3] = 3, we know that P[3] = 1.
    /// Repeating these steps gives us P[4] = 0, P[5] = 0, P[6] = 0, P[7] = 1, and P[8] = 1.
    /// We check our work by noting that Q[8] = P[7] + P[8] = 1 + 1 = 2. 
    /// Since this equation works out, we are finished, and we have recovered one possible original string.
    /// Now we repeat the process, assuming the opposite about P[0]:
    /// Assume P[0] = 1.
    /// Because Q[0] = P[0] + P[1] = 1 + P[1] = 0, we know that P[1] = 0.
    /// Because Q[1] = P[0] + P[1] + P[2] = 1 + 0 + P[2] = 2, we know that P[2] = 1.
    /// Now note that Q[2] = P[1] + P[2] + P[3] = 0 + 1 + P[3] = 3, which leads us to the conclusion that P[3] = 2. 
    /// However, this violates the fact that each character in the original string must be '0' or '1'. 
    /// Therefore, there exists no such original string P where the first digit is '1'.
    /// Note that this algorithm produces at most two decodings for any given encrypted string. 
    /// There can never be more than one possible way to decode a string once the first binary digit is set.
    /// Given a String message, containing the encrypted string, return a String[] with exactly two elements. 
    /// The first element should contain the decrypted string assuming the first character is '0'; 
    /// the second element should assume the first character is '1'. 
    /// If one of the tests fails, return the string "NONE" in its place. 
    /// For the above example, you should return {"011100011", "NONE"}.
    /// 
    /// Constraints
    /// message will contain between 1 and 50 characters, inclusive.
    /// Each character in message will be either '0', '1', '2', or '3'.
    /// </summary>
    public class BinaryCode
    {
        public string[] Decode(string message)
        {
            const int o = 2;
            var r = new string[o];
            var l = message.Length;
            for (var i = 0; i < o; i++)
            {
                var p1 = i;
                var p2 = 0;
                r[i] = p1.ToString(CultureInfo.InvariantCulture);
                for (var j = 0; j < l; j++)
                {
                    var c = Int32.Parse(message.Substring(j, 1));
                    var q = c - (p1 + p2);
                    if (q != 0 && q != 1)
                    {
                        r[i] = "NONE";
                        break;
                    }
                    p2 = p1;
                    p1 = q;
                    if (j != l - 1)
                    {
                        r[i] += q;                        
                    }
                }
            }
            return r;
        }
    }
}