class QuestionOneSolutions {
    static void Main (string[] args) {
        int solutionOne = SolutionOne();
        int solutionTwo = SolutionTwo();
        int solutionThree = SolutionThree();

        Console.WriteLine(solutionOne.ToString());
        Console.WriteLine(solutionTwo.ToString());
        Console.WriteLine(solutionThree.ToString());
    }

    /* Sum all integers from 1 to 1000 that are either multiples of 3, 5 or both
    Runtime: O(n) - loops through each value
    Memory: O(1) - only one sum is stored
    */
    private static int SolutionOne() {
        int sum = 0;
        for (int i = 1; i < 1000; i++){
            if ((i % 3 == 0) || (i % 5 == 0)) {
                sum += i;
            }
        }
        return sum;
    }

    /*
    Sum all integers from 1 to 1000 that are either multiples of 3, 5 or both
    Runtime: O(n) - loops through only the selected values, though this set grows with n.
    Memory: O(1) - only 3 sums are stored.
    */
    private static int SolutionTwo() {
        int threeSum = 0;
        int fiveSum = 0;
        int fifteenSum = 0;

        for (int i=3; i<1000; i+=3){
            threeSum += i;
        }
        for (int i=5; i<1000; i+=5){
            fiveSum += i;
        }
        for (int i=15; i<1000; i+=15){
            fifteenSum += i;
        }
        return threeSum + fiveSum - fifteenSum;
    }
    
    /*
    Sum all integers from 1 to 1000 that are either multiples of 3, 5 or both
    Runtime: O(1) - no loops
    Memory: O(1) - only 3 integers stored.
    */
    private static int SolutionThree() {
        return SumDivisibleBy(3, 999) + SumDivisibleBy(5, 999) - SumDivisibleBy(15, 999);
    }

    // Sum the values from value to maxValue that are multiples of value
    private static int SumDivisibleBy(int value, int maxValue){
        // largestOtherDivisior=333 in the case of value=3, maxValue=999.
        int largestOtherDivisor = maxValue / value;
        return value * largestOtherDivisor * (largestOtherDivisor + 1) / 2;
    }
}   