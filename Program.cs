using static QuestionOneSolutions;
using static QuestionTwoSolutions;
using static QuestionThreeSolutions;
using static QuestionFourSolutions;



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


    }
}