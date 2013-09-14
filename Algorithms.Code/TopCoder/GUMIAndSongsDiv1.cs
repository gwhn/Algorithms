using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// Gumi loves singing. 
    /// She knows N songs. 
    /// The songs are numbered 0 through N-1. 
    /// She now has some time and she would love to sing as many different songs as possible. 
    /// You are given a int[] duration. 
    /// For each i, duration[i] is the duration of song i in Gumi's time units. 
    /// Gumi finds it difficult to sing songs with quite different tones consecutively. 
    /// You are given a int[] tone with the following meaning: 
    /// If Gumi wants to sing song y immediately after song x, 
    /// she will need to spend |tone[x]-tone[y]| units of time resting between the two songs.
    /// (Here, || denotes absolute value.) 
    /// You are also given an int T. 
    /// Gumi has T units of time for singing. 
    /// She can start singing any song she knows immediately at the beginning of this time interval. 
    /// Compute the maximal number of different songs she can sing completely within the given time.
    /// 
    /// Constraints
    /// duration and tone will each contain between 1 and 50 elements, inclusive.
    /// duration and tone will contain the same number of elements.
    /// Each element of duration will be between 1 and 100,000, inclusive.
    /// Each element of tone will be between 1 and 100,000, inclusive.
    /// T will be between 1 and 10,000,000, inclusive.
    /// </summary>
    public class GumiAndSongsDiv1
    {
        public int MaxSongs(int[] duration, int[] tone, int T)
        {
            var n = duration.Length;
            var songs = new List<Song>(n);

            for (int i = 0; i < n; i++)
            {
                songs.Add(new Song(duration[i], tone[i]));
            }
            songs.Sort();
            var adj = new int[n, n];
            const int inf = 1000000;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    adj[i, j] = inf;
                }
            }
            adj[0, 0] = 0;
            for (int i = 0; i < n; i++)
            {
                adj[1, i] = songs[i].Tone;
            }
            for (int i = 2; i <= n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < j; k++)
                    {
                        if (adj[i-1, k] != inf)
                        {
                            adj[i, j] = Math.Min(adj[i, j],
                                                 adj[i - 1, k] + 
                                                 Math.Abs(songs[j].Duration - songs[k].Duration) +
                                                 songs[j].Tone);
                        }
                    }
                }
            }
            var result = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (adj[i,j] <= T)
                    {
                        result = Math.Max(result, i);
                    }
                }
            }
            return result;
        }

        public class Song : IComparable<Song>
        {
            public Song(int duration, int tone)
            {
                Duration = duration;
                Tone = tone;
            }

            public int Duration { get; set; }
            public int Tone { get; set; }

            public int CompareTo(Song other)
            {
                return Tone - other.Tone;
            }
        }
    }
}
