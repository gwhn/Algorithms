using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// Graphical user interfaces rely on text routines to properly display words on various GUI components. 
    /// Being able to determine the width in pixels of a line of text is useful for centering the text in a window. 
    /// You will be given a sentence of letters and spaces. 
    /// You will also be given the letter widths for both uppercase and lowercase letters of a particular font. 
    /// You must return the width of the sentence.
    /// Both uppercase and lowercase contain 26 elements. 
    /// The first element of uppercase is the width of 'A' and the last is the width of 'Z'. 
    /// The first element of lowercase is the width of 'a' and the last is the width of 'z'. 
    /// The width of the space character is always 3 pixels. 
    /// When a line of text is rendered, there is a gap of 1 pixel between each pair of adjacent characters.
    /// 
    /// Constraints
    /// sentence will contain between 1 and 50 characters, inclusive.
    /// sentence will only contain uppercase letters ('A'-'Z'), lowercase letters ('a'-'z'), and spaces.
    /// uppercase will contain exactly 26 elements.
    /// lowercase will contain exactly 26 elements.
    /// Each value in uppercase and lowercase will be between 1 and 36, inclusive.
    /// </summary>
    public class FontSize
    {
        public int GetPixelWidth(String sentence, int[] uppercase, int[] lowercase)
        {
            var total = 0;
            var n = sentence.Length;
            for (int i = 0; i < n; i++)
            {
                var ch = sentence[i];
                if (ch >= 65 && ch <= 90)
                {
                    total += uppercase[ch-65];
                }
                else if (ch >= 97 && ch <= 122)
                {
                    total += lowercase[ch-97];
                }
                else // must be a space
                {
                    total += 3;
                }
                if (i != n - 1)
                {
                    total++;
                }
            }
            return total;
        }
    }
}
