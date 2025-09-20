namespace LeetCode.Problems._3100;

public class Solution
{
    public int MaxBottlesDrunk(int numBottles, int numExchange)
    {
        return NumWaterBottles(numBottles, 0, numExchange);
    }

    private int NumWaterBottles(int fullBottles, int emptyBottles, int numExchange)
    {
        if (fullBottles == 0 && emptyBottles < numExchange)
        {
            return 0;
        }

        if (emptyBottles >= numExchange)
        {
            fullBottles++;
            emptyBottles -= numExchange++;

            return 0 + NumWaterBottles(fullBottles, emptyBottles, numExchange);
        }


        return fullBottles + NumWaterBottles(0, emptyBottles + fullBottles, numExchange);

    }
}