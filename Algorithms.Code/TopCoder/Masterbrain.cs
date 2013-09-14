namespace Algorithms.Code
{
    /// <summary>
    /// Masterbrain is a two player board game in which one player decides on a secret combination of digits, 
    /// while the other must figure it out in 10 guesses or less. 
    /// The game differs from Mastermind in that the player making the secret combination is allowed to lie once.
    /// The game consists of one player making a sequence of guesses about what the secret combination is, 
    /// and the other player giving him or her certain information about the quality of the guess. 
    /// The following is how each guess is analyzed: 
    ///     if a digit is in the correct position then a black peg is given. 
    ///     If a digit is in the guess but in the wrong position then a white peg is given. 
    ///     For all other cases no pegs are given.
    /// For example, if guess = "1234", secret = "2335". 
    /// Analyzing the guess digit by digit; 
    ///     the '1' is not in secret - no pegs given. 
    ///     The '2' is in secret but not in the right place - white peg given. 
    ///     The '3' is in secret and in the right place - black peg given. 
    ///     The '4' is not in secret - no pegs given. 
    ///     Result should be "1b 1w", meaning one black peg and one white peg. 
    /// Now, if guess is "2334" and secret is "3224", we have the following: 
    ///     '2' is in secret, but not in the right place - white peg given. 
    ///     The first '3' is in secret, but not in the right place - white peg given. 
    ///     Since the '3' in secret has been used, the second '3' in guess should return no pegs. 
    ///     The '4' is in secret and in the right place - black peg given. 
    ///     Result should be "1b 2w".
    /// Given a string[] of guesses and a string[] of results for those guesses, 
    /// return the total number of possible secret combinations, 
    /// assuming that exactly one of the results is incorrect. 
    /// Each element of results will be formatted as "&lt;x&gt;b &lt;y&gt;w", 
    /// where &lt;x&gt; and &lt;y&gt; are the number of black and white pegs respectively.
    /// 
    /// Notes
    /// The second player must lie exactly once.
    /// Black pegs always take precedence over white pegs. 
    /// Thus, when analyzing a guess, black pegs are assigned first, and then white pegs are assigned.
    /// No digit in either a guess or a secret combination may be involved in giving more than one peg.
    /// 
    /// Constraints
    /// guesses and results will have the same number of elements.
    /// guesses will have between 1 and 10 elements inclusive.
    /// results will have between 1 and 10 elements inclusive.
    /// each element in guesses will contain exactly 4 characters and will only contain digits between '1' and '7' inclusive.
    /// each element in results will contain exactly 5 characters.
    /// each element of results will be formatted as follows: 
    /// "&lt;x&gt;b &lt;y&gt;w", where &lt;x&gt; represents the number of black pegs and &lt;y&gt; represents the number of white pegs in a guess. 
    /// &lt;x&gt; and &lt;y&gt; are non-negative integers whose sum is less than or equal to 4.
    /// results will never have "3b 1w", because that is impossible.
    /// </summary>
    public class Masterbrain
    {
        public int PossibleSecrets(string[] guesses, string[] results)
        {
            int count = 0;
            char[] secret = new char[4];
            for (secret[0] = '1'; secret[0] <= '7'; secret[0]++)
                for (secret[1] = '1'; secret[1] <= '7'; secret[1]++)
                    for (secret[2] = '1'; secret[2] <= '7'; secret[2]++)
                        for (secret[3] = '1'; secret[3] <= '7'; secret[3]++)
                        {
                            if (Check(guesses, results, new string(secret)))
                            {
                                count++;
                            }
                        }
            return count;
        }

        private static bool Check(string[] guesses, string[] results, string secret)
        {
            int lies = 0;
            for (int i = 0; i != guesses.Length; i++)
            {
                string res = Score(guesses[i], secret);
                if (res != results[i])
                {
                    if (lies == 1)
                    {
                        return false;
                    }
                    else
                    {
                        lies = 1;
                    }
                }
            }
            return lies == 1;
        }

        private static string Score(string guess, string secret)
        {
            int black = 0;
            int white = 0;
            bool[] usedGuesses = new bool[4];
            bool[] usedSecrets = new bool[4];
            for (int i = 0; i != 4; i++)
            {
                if (guess[i] == secret[i])
                {
                    black++;
                    usedGuesses[i] = true;
                    usedSecrets[i] = true;
                }
            }
            for (int i = 0; i != 4; i++)
            {
                for (int j = 0; j != 4; j++)
                {
                    if (!usedGuesses[i] && !usedSecrets[j] && guess[i] == secret[j])
                    {
                        white++;
                        usedGuesses[i] = true;
                        usedSecrets[j] = true;
                    }
                }
            }
            return "" + black + "b " + white + "w";
        }
    }
}
