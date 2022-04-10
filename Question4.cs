public static class QuestionFourSolutions
{
    /*
    Return the largest palindrome formed from the product of two three-digit numbers
    */
    public static int LargestPalindromeProduct(int n)
    {
        // the largest possible number is 999^2, 998,001
        // thus, the first 3 chars of that number are:
        int firstHalf = 998;

        IEnumerable<int> palindromes = nextLargestPalindrome(firstHalf);

        foreach (int palindrome in palindromes)
        {
            if (isProduct(palindrome))
            {
                return palindrome;
            }
        }
        return -1;
    }

    /* Return whether or not a number if the product of two numbers with
    the supplied number of digits */
    private static bool isProduct(int n)
    {
        int rootN = (int)Math.Sqrt(n);
        for (int i = rootN; i >= 100; i--)
        {
            if (n % i == 0)
            {
                // i and n/i are the two integer factors
                if (n / i <= 999)
                {
                    return true;
                }
            }
        }
        return false;
    }

    // Return a palindrome from the 'first half' of the number.
    private static int makePalindrome(int firstHalf)
    {
        char[] reversedArray = firstHalf.ToString().ToCharArray();
        Array.Reverse(reversedArray);

        string secondHalf = new string(reversedArray);
        string palindrome = string.Format("{0}{1}", firstHalf.ToString(), secondHalf);
        return int.Parse(palindrome);
    }

    // Generate the next largest Palindrome from the first half of the starting number.
    private static IEnumerable<int> nextLargestPalindrome(int firstHalf)
    {
        while (firstHalf > 1)
        {
            yield return makePalindrome(firstHalf);
            firstHalf--;
        }
    }

}