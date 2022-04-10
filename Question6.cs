public static class Question6Solutions
{

    /* let numbers = [1..n]
    Compute the difference between the square of the sum of numbers
    and the sum of squares of each number*/
    public static int SumSquareDifference(int maxNumber)
    {
        IEnumerable<int> numbers = Enumerable.Range(1, maxNumber);
        int sumOfSquares = 0;
        int sum = 0;
        int squareOfSums = 0;

        foreach (int number in numbers)
        {
            sumOfSquares += number * number;
            sum += number;
        }
        squareOfSums = sum * sum;
        return squareOfSums - sumOfSquares;
    }
}
