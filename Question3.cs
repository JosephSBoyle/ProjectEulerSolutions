using System;
public static class QuestionThreeSolutions
{
    /*
    Compute the largest prime factor of n

    Memory: O(1) - only the current prime is stored
    Warning: not sure this runtime is correct
    Runtime: O(n^(5/2)) - repeat the calculation of the next prime, O(n^(3/2)), `n` times
    */
    public static long LargestPrimeFactor(long n)
    {
        long prime = nextPrime(1);
        long limit = (long)Math.Sqrt(n);
        while (true)
        {
            if (n % prime == 0) // prime is a factor of n
            {
                long otherFactor = n / prime;
                if (isPrime(otherFactor))
                {
                    return otherFactor;
                }
                else
                {
                    return LargestPrimeFactor(otherFactor);
                }
            }
            if (prime > limit)
            {
                // `n` must be prime and it's own largest prime factor
                // (all positive integers greater than 1 have a prime factor.)
                return n;
            }
            prime = nextPrime(prime);
        }
    }

    /*
    Find the next prime number following `n`

    Memory: O(1) - only the candidate number is stored
    Warning: not sure this runtime is correct
    Runtime: O(√n * ln(n)) - check each number (O(√n)) and each check takes up to O(√n)
    */
    private static long nextPrime(long n)
    {
        long candidate = n + 1;

        while (!isPrime(candidate))
        {
            candidate += 1;
        }
        return candidate;
    }

    /*
    Return whether or not the number is a prime
    
    Memory: O(1) - only the candidate number is stored
    Runtime: O(√n) - worst case loops from 2 to √n
    */
    private static bool isPrime(long candidate)
    {
        for (long i = 2; i <= Math.Sqrt(candidate); ++i)
        {
            if (candidate % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}