using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// The purpose of a roundabout is to control the flow of traffic at a busy intersection. 
    /// A roundabout has 4 entry points: from the North, East, South and West; 
    /// and 4 exit points at the same locations.
    /// Cars can enter, leave or move one position on the roundabout. 
    /// Each of those events requires one second. 
    /// All the events can take place simultaneously. 
    /// So if there are two cars on the roundabout, one behind the other, then they can both move during the next second. 
    /// A car decides whether to enter the roundabout based on its knowledge from the previous second. 
    /// A car will always enter if it has the right to do so.
    /// A car has the right to enter only if there are no cars to its immediate left 
    /// (either on the roundabout or waiting to get on the roundabout) 
    /// and it is the first car in line at the entry point. 
    /// A special case occurs if there is a car at each of the 4 entry points. 
    /// In this case, the car from the North will wait until there are no cars to its left on the roundabout 
    /// and then will be the first to enter.
    /// Once the car is on the roundabout, it moves counter-clockwise until it exits the roundabout. 
    /// There are 4 positions on the roundabout. 
    /// So for example, it would take 1 second to enter the roundabout, 
    /// 2 seconds to complete half a lap and another 1 second to exit the roundabout.
    /// Each parameter of the input is a second by second account of cars coming from that direction with their intended exit locations. 
    /// Intended exit locations will be N (North), E (East), S (South) and W (West). 
    /// A '-' means that no car arrived during that second at the given entry point. 
    /// Thus, for example, character i of north represents the direction in which a car (if there is one) 
    /// arriving from the north at time i will leave the roundabout. 
    /// So, at time i, this car will be added to the end of the line at the north entry point to the roundabout. 
    /// Cars will not be allowed to exit the roundabout at the point of their entry.
    /// Given the lists of cars coming from the 4 directions, return the total time required for all cars to leave the roundabout.
    /// 
    /// Constraints
    /// north, east, south and west will contain between 0 and 50 characters inclusive.
    /// north, east, south and west must only contain 'N', 'W', 'S', 'E' and '-' characters.
    /// north will NOT contain the character 'N'.
    /// east will NOT contain the character 'E'.
    /// south will NOT contain the character 'S'.
    /// west will NOT contain the character 'W'.
    /// </summary>
    public class Roundabout
    {
        private const char N = 'N';
        private const char E = 'E';
        private const char S = 'S';
        private const char W = 'W';
        private const char O = '\0';
        private const char D = '-';

        public int ClearUpTime(string north, string east, string south, string west)
        {
            var time = 0;
            var state = new char[2][];
            state[0] = new char[4];
            state[1] = new char[4];
            do
            {
                var junctions = new char[4];
                var roundabout = new char[4];
                Enter(ref north, ref east, ref south, ref west, ref junctions, ref state);
                Move(ref junctions, ref roundabout, ref state);
                Leave(ref roundabout);
                state[0] = junctions;
                state[1] = roundabout;
                time++;
            } while (!IsEmpty(state));
            return time == 1 ? 0 : time + 1;
        }

        private static void Leave(ref char[] roundabout)
        {
            if (roundabout[0] == N)
            {
                roundabout[0] = O;
            }
            if (roundabout[1] == E)
            {
                roundabout[1] = O;                
            }
            if (roundabout[2] == S)
            {
                roundabout[2] = O;                
            }
            if (roundabout[3] == W)
            {
                roundabout[3] = O;                
            }
        }

        private static bool IsEmpty(IEnumerable<char[]> state)
        {
            return state.All(x => !x.Any(y => y != O && y != D));
        }

        private static void Move(ref char[] junctions, ref char[] roundabout, ref char[][] state)
        {
            for (int i = 0; i < state[1].Length; i++)
            {
                if (!IsClear(state[1][i]))
                {
                    var j = i == 0 ? roundabout.Length - 1 : i - 1;
                    roundabout[j] = state[1][i];
                }
            }
            var isBlocked = true;
            for (int i = 0; i < state[0].Length; i++)
            {
                if (!IsClear(junctions[i]))
                {
                    var j = i < junctions.Length - 1 ? i + 1 : 0;
                    if (IsClear(junctions[j]) && IsClear(state[1][j]))
                    {
                        roundabout[i] = junctions[i];
                        junctions[i] = O;
                    }
                }
                else
                {
                    isBlocked = false;
                }
            }
            if (isBlocked)
            {
                if (IsClear(state[1][1]))
                {
                    roundabout[0] = junctions[0];
                    junctions[0] = O;
                }
            }
        }

        private static void Enter(ref string north, ref string east, ref string south, ref string west, ref char[] junctions, ref char[][] state)
        {
            if (north.Length > 0 && IsClear(state[0][0]))
            {
                junctions[0] = north[0];
                north = north.Substring(1);
            }
            else
            {
                junctions[0] = state[0][0];
            }
            if (east.Length > 0 && IsClear(state[0][1]))
            {
                junctions[1] = east[0];
                east = east.Substring(1);
            }
            else
            {
                junctions[1] = state[0][1];
            }
            if (south.Length > 0 && IsClear(state[0][2]))
            {
                junctions[2] = south[0];
                south = south.Substring(1);
            }
            else
            {
                junctions[2] = state[0][2];
            }
            if (west.Length > 0 && IsClear(state[0][3]))
            {
                junctions[3] = west[0];
                west = west.Substring(1);
            }
            else
            {
                junctions[3] = state[0][3];
            }
        }

        private static bool IsClear(char junction)
        {
            return (junction == O || junction == D);
        }
    }
}
