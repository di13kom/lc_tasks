namespace LeetCode.Problems._1672;

public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int retVal = 0;
        int curSum;

        for (int i = 0; i < accounts.Length; i++)
        {
            curSum = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                curSum += accounts[i][j];
            }
            retVal = Math.Max(retVal, curSum);
        }
        return retVal;
    }
}