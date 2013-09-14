using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// A common way to rank athletic teams is based on each team's winning percentage. 
    /// However, when two teams have similar percentages, 
    /// the team that played against better opponents will be ranked above the team that had easier opponents. 
    /// The measure of how difficult a team's opponents are, is known as the team's strength of schedule. 
    /// A team that has faced tough opponents is said to have a strong schedule, 
    /// and a team with poor opponents is said to have a weak schedule.
    /// We will use the cumulative winning percentage of Team X's opponents 
    /// (the teams that Team X played against) as a measure of Team X's strength of schedule. 
    /// This percentage is the number of wins recorded by Team X's opponents divided by the total games they played, 
    /// excluding games that were played against Team X.
    /// Given a String[] of teams that contains the name of each team and 
    /// a String[] results that indicates the outcome of games played during the season, 
    /// return a String[] containing the names of the teams, 
    /// ordered from strongest schedule to weakest. 
    /// Teams with equivalent schedule strengths should appear in increasing alphabetical order.
    /// Element i of results corresponds to team i whose name is found in teams at index i. 
    /// Character j of element i of results will be one of 'W', 'L' or '-' respectively 
    /// indicating whether team i won, lost, or did not play a game against team j.
    /// 
    /// Constraints
    /// teams will contain between 3 and 50 elements, inclusive.
    /// teams and results will contain the same number of elements.
    /// Each element of teams will contain between 1 and 50 characters, inclusive.
    /// Each element of teams will only contain uppercase letters ('A'-'Z').
    /// Each element of teams will be distinct.
    /// Each element of results will contain N characters, where N is the number of elements in teams.
    /// Each element of results will only contain 'W', 'L' and '-'.
    /// The ith character of the ith element of results will be '-'.
    /// If the jth character of the ith element of results is 'W' then the ith character of the jth element of results will be 'L', and vice versa.
    /// Every team will play at least two games.
    /// </summary>
    public class ScheduleStrength
    {
        public String[] Calculate(String[] teams, String[] results)
        {
            var n = teams.Length;
            var records = new List<Team>(n);
            for (var i = 0; i < n; i++)
            {
                var name = teams[i];
                var wins = 0;
                var losses = 0;
                for (var j = 0; j < n; j++)
                {
                    if (results[i][j] != '-') // did they play?
                    {
                        for (var k = 0; k < n; k++)
                        {
                            if (k != i) // not against us!
                            {
                                switch (results[j][k])
                                {
                                    case 'W':
                                        wins++;
                                        break;
                                    case 'L':
                                        losses++;
                                        break;
                                }
                            }
                        }
                    }
                }
                records.Add(new Team(name, wins, losses));
            }
            return (from x in records
                    orderby x.Percentage descending, x.Name 
                    select x.Name).ToArray();
        }

        private class Team
        {
            private readonly int _wins;
            private readonly int _losses;

            public Team(string name, int wins, int losses)
            {
                Name = name;
                _wins = wins;
                _losses = losses;
            }

            public string Name { get; private set; }

            public decimal Percentage
            {
                get { return (decimal) _wins/(_wins + _losses); }
            }
        }
    }
}
