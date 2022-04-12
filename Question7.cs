public static class Question7Solution
{
    public static int nthPrimeNumber(int n)
    {
        int prime = 0;
        for (int i = 0; i <= 10001; i++){
            prime = (int)nextPrime(prime);
        }
        return prime;
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