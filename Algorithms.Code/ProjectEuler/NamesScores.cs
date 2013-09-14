using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// Using names.txt (right click and 'Save Link/Target As...'), 
    /// a 46K text file containing over five-thousand first names, 
    /// begin by sorting it into alphabetical order. 
    /// Then working out the alphabetical value for each name, 
    /// multiply this value by its alphabetical position in the list to obtain a name score.
    /// For example, when the list is sorted into alphabetical order, COLIN, 
    /// which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. 
    /// So, COLIN would obtain a score of 938 × 53 = 49714.
    /// What is the total of all the name scores in the file?
    /// </summary>
    public class NamesScores
    {
        public long Solve(string path)
        {
            var text = File.ReadAllText(path);
            var names = text.Split(',');
            var list = new List<string>(names.Length);
            list.AddRange(names.Select(x => x.Remove(x.Length - 1, 1).Remove(0, 1)));
            list.Sort();
            return list.Select((t, i) => t.Sum(x => x - 64)*(i + 1)).Sum();
        }
    }
}
