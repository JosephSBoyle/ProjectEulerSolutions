public static class Question5Solutions
{

    public static int SmallestEvenlyDivisibleByTwenty()
    {
        IEnumerable<int> nextCandidates = nextCandidate();

        foreach (int candidate in nextCandidates)
        {
            if (isDivisibleByAllUpTo20(candidate))
            {
                return candidate;
            }
        }

        return -1;
    }

    private static IEnumerable<int> nextCandidate()
    {
        int number = 20;
        while (true)
        {
            yield return number;
            number += 20;
        }
    }

    private static bool isDivisibleByAllUpTo20(int candidate)
    {
        for (int i = 19; i > 1; i--)
        {
            if (candidate % i != 0)
            {
                return false;
            }
        }
        return true;
    }
}

public static class Question5Optimized
{
    private static int[] divisors = new int[] { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, };

    public static int SmallestEvenlyDivisibleByTwenty()
    {
        IEnumerable<int> nextCandidates = nextCandidate();

        foreach (int candidate in nextCandidates)
        {
            if (isDivisibleByAllUpTo20(candidate))
            {
                return candidate;
            }
        }

        return -1;
    }

    private static IEnumerable<int> nextCandidate()
    {
        int number = 20;
        while (true)
        {
            yield return number;
            number += 20;
        }
    }

    private static bool isDivisibleByAllUpTo20(int candidate)
    {
        foreach(int divisor in divisors)
        {
            if (candidate % divisor != 0)
            {
                return false;
            }
        }
        return true;
    }
}