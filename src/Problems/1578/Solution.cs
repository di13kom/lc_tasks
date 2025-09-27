namespace LeetCode.Problems._1578;

public class Solution
{
    public int MinCost(string colors, int[] neededTime)
    {
        int retVal = 0;
        int curVal = neededTime[0];
        int seqCnt = 1;
        int curSum = neededTime[0];
        int length = neededTime.Length;

        for (int i = 1; i < length; i++)
        {
            if (colors[i] == colors[i - 1])
            {
                seqCnt++;
                curVal = Math.Max(curVal, neededTime[i]);
                curSum += neededTime[i];
            }
            else
            {
                if (seqCnt > 1)
                    retVal += curSum - curVal;
                curVal = neededTime[i];
                seqCnt = 1;
                curSum = neededTime[i];
            }
        }
        if (seqCnt > 1)
            retVal += curSum - curVal;

        return retVal;
    }
}