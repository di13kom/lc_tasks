namespace LeetCode.Problems._1523;

public class Solution
{
    public int CountOdds(int low, int high)
    {
        int retVal;

        var diff = high - low + 1;

        if (diff % 2 == 0)
        {
            retVal = diff / 2;
        }
        else
        {
            if (low % 2 == 0)
            {
                retVal = diff / 2;
            }
            else
            {
                retVal = diff / 2 + 1;
            }
        }

        return retVal;
    }
}