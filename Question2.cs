public static class QuestionTwoSolutions {
    /*
    Return a list of fibonacci integers less than or equal to maximum value.
    Runtime: O(n) - loops through the fibonacci numbers twice
    Memory: O(log(n)) - a list of the fibonnaci numbers is stored. The count of fibonacci numbers lower than n
        increases logarithmically with n.
    */
    public static int SumEvenFibonnaciNumbers1(int n) {
        List<int> fibonnaciNumbers = fibonacci(n);
        int sum = 0;

        foreach (int fib in fibonnaciNumbers) {
            if (fib % 2 == 0) {
                sum += fib;
            }
        }
        return sum;
    }

    // generate a list of the fibonnaci numbers lower than the max value.
    private static List<int> fibonacci(int max) {
        List<int> fibonnaciNumbers = new List<int>() { 0, 1 };
        int listLen = 2;
        int newNum = 0;

        while (newNum < max)
        {
            fibonnaciNumbers.Add(newNum);
            listLen += 1;
            newNum = fibonnaciNumbers[^2] + fibonnaciNumbers[^1];
        }
        return fibonnaciNumbers;
    }
    /*
    Return the sum of even fibonacci numbers less than or equal to a maximum value.
    Runtime: O(n) - loops through each of the fibonacci numbers once
    Memory: O(1) - only the last two fibonacci numbers are stored
    */
    public static int SumEvenFibonnaciNumbers2(int n) {
        int[] lastFibonnaciNumbers = { 0, 1 };
        int sum = 0;
        int nextFib = 1;
        
        while (nextFib < n) {
            if (nextFib % 2 == 0) {
                sum += nextFib;
            }
            lastFibonnaciNumbers[0] = lastFibonnaciNumbers[1];
            lastFibonnaciNumbers[1] = nextFib;
            nextFib = lastFibonnaciNumbers.Sum();
        }
        return sum;
    }
    /*
    Return the sum of even fibonacci numbers less than or equal to a maximum value.

    Notes:
        This method takes advantage of the fact that we can compute the next even fibonnaci number
        using exclusively previous even values in the series

    Runtime: O(n) - loops through each *even* of the fibonacci numbers once
    Memory: O(1) - only the last two even fibonacci numbers are stored
    */
    public static int SumEvenFibonnaciNumbers3(int n) {
        // Fn = Fn-1 + Fn-2 = ... = 4Fn-3 + Fn-6
        int fib3 = 2;
        int fib6 = 0;

        int sum = 0;
        int nthFib = 2;
        
        while (nthFib < n) {
            sum += nthFib;
            nthFib = 4*fib3 + fib6;

            fib6 = fib3;
            fib3 = nthFib;
        }
        return sum;
    }
}