using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// It is a common practice in cryptography to remove the spaces from a message before encoding it to help to disguise its structure. 
    /// Even after it is then decoded, we are left with the problem of putting the spaces back in the message.
    /// Create a class MessageMess that contains a method restore that takes a String[] dictionary of possible words 
    /// and a String message as inputs. 
    /// It returns the message with single spaces inserted to divide the message into words from the dictionary. 
    /// If there is more than one way to insert spaces, it returns "AMBIGUOUS!" 
    /// If there is no way to insert spaces, it returns "IMPOSSIBLE!" 
    /// The return should never have any leading or trailing spaces.
    /// 
    /// Notes
    /// Don't forget the '!' at the end of the two special returns
    /// A proper message may require 0 spaces to be inserted
    /// 
    /// Constraints
    /// dictionary will contain between 1 and 50 elements inclusive
    /// the elements of dictionary will be distinct
    /// each element of dictionary will contain between 1 and 50 characters
    /// message will contain between 1 and 50 characters
    /// every character in message and in each element of dictionary will be an uppercase letter 'A'-'Z'
    /// </summary>
    public class MessageMess
    {
        public String Restore(String[] dictionary, String message)
        {
            var count = 0;
            var list = new List<string>();
            var temp = message;
            var result = "";
            while (temp.Length > 0)
            {
                foreach (var word in dictionary)
                {
                    if (temp.Contains(word))
                    {
                        var start = temp.IndexOf(word, StringComparison.Ordinal);
                        var length = word.Length;
                        temp = temp.Remove(start, length);
                        result += word + " ";
                    }
                }
                if (temp.Length == 0)
                {
                    list.Add(result.Trim());                    
                }
            }
            return list.Count == 1
                       ? list[0]
                       : list.Count == 0
                             ? "IMPOSSIBLE!"
                             : "AMBIGUOUS!";
        }
    }
}
