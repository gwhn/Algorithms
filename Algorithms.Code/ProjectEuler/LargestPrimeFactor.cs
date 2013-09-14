namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    public class LargestPrimeFactor
    {
        public long Max(long n)
        {
            var max = 0;
            for (int i = 2; i <= n; i++)
            {
                if (Primes.IsPrime(i) && n%i == 0)
                {
                    n /= i;
                    max = i;
                }
            }
            return max;
        }
    }
}
