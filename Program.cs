using static QuestionOneSolutions;
using static QuestionTwoSolutions;


class Solutions {
    static void Main (string[] args) {
        // Question 1 solutions
        Console.WriteLine(Q1SolutionOne().ToString());
        Console.WriteLine(Q1SolutionTwo().ToString());
        Console.WriteLine(Q1SolutionThree().ToString());

        // Question 2 solutions
        int n = 4000000;
        Console.WriteLine(SumEvenFibonnaciNumbers1(n).ToString());
        Console.WriteLine(SumEvenFibonnaciNumbers2(n).ToString());
        Console.WriteLine(SumEvenFibonnaciNumbers3(n).ToString());
    }
}