
namespace LeetCode.Problems._1518;

public class Solution
{
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        return numBottles + NumWaterBottles(numBottles / numExchange, numBottles % numExchange, numExchange);

    }

    private int NumWaterBottles(int fullBottles, int emptyBottles, int numExchange)
    {
        if (fullBottles == 0)
        {
            return 0;
        }

        var newEmpty = fullBottles + emptyBottles;

        return fullBottles + NumWaterBottles(newEmpty / numExchange, newEmpty % numExchange, numExchange);

    }
}