using static QuestionOneSolutions;
using static QuestionTwoSolutions;
using static QuestionThreeSolutions;
using static QuestionFourSolutions;
using static Question5Solutions;
using static Question6Solutions;
using static Question7Solution;


class Solutions
{
    static void Main(string[] args)
    {
        // Question 1 solutions
        Console.WriteLine(Q1SolutionOne());
        Console.WriteLine(Q1SolutionTwo());
        Console.WriteLine(Q1SolutionThree());

        // Question 2 solutions
        int n = 4000000;
        Console.WriteLine(SumEvenFibonnaciNumbers1(n));
        Console.WriteLine(SumEvenFibonnaciNumbers2(n));
        Console.WriteLine(SumEvenFibonnaciNumbers3(n));

        // Question 3 Solutions
        long m = 600851475143;
        Console.WriteLine(LargestPrimeFactor(m));

        // Question 4 Solutions
        n = 99;
        Console.WriteLine(LargestPalindromeProduct(n));

        // Question 5 Solution
        Console.WriteLine(SmallestEvenlyDivisibleByTwenty());
        Console.WriteLine(Question5Optimized.SmallestEvenlyDivisibleByTwenty());

        // Question 6 Solution
        Console.WriteLine(Question6Solutions.SumSquareDifference(100));

        // Question 7 Solution
        Console.WriteLine(Question7Solution.nthPrimeNumber(10001));

    }
}