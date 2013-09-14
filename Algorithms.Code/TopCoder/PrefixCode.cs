using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// A prefix code is a set of words in which no word is a prefix of another word in the set. 
    /// A word v is said to be a prefix of a word w if w starts with v.  
    /// An important property of prefix codes is that they are uniquely decodable. 
    /// Prefix codes are commonly used - telephone numbers are an everyday example 
    /// (as you probably don't want a stranger to pick up the phone call you make just 
    /// because his number is a prefix of the number you intend to dial). 
    /// Prefix codes are also very popular in computer science, 
    /// the Huffman code used for data compression being a famous example.  
    /// Given a String[] words, return the String "Yes" if that set of words is a prefix code 
    /// or return the String "No, i" if it is not, where i is replaced by the lowest 0-based 
    /// index of a String in words that is a prefix of another String in words. 
    /// (That index should have no extra leading zeros.)
    /// 
    /// Notes
    /// Letters are case sensitive (e.g. "No" is not a prefix of "not").
    /// Do not forget the single space between the comma and i in "No, i"
    /// 
    /// Constraints
    /// words contains between 1 and 50 elements, inclusive.
    /// Each element of words contains between 1 and 50 characters, inclusive.
    /// Each element of words consists only of characters '0'-'9', 'A'-'Z' and 'a'-'z', inclusive.
    /// No two elements of words are equal (as the input represents a set).
    /// </summary>
    public class PrefixCode
    {
        public String IsOne(String[] words)
        {
            var n = words.Length;
            var p = -1;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        if (words[j].StartsWith(words[i], false, CultureInfo.InvariantCulture))
                        {
                            return string.Format("No, {0}", i);
                        }
                    }
                }
            }
            return "Yes";
        }
    }
}
