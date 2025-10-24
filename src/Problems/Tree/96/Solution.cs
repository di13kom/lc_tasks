namespace LeetCode.Problems.Tree._96;

public class Solution
{
    int[][] dp;
    public int NumTrees(int n)
    {
        dp = new int[n][];
        for (int i = 0; i < n; i++)
        {
            dp[i] = new int[n];
        }

        int retVal = 0;
        for (int i = 1; i <= n; i++)
        {
            retVal += GenerateTrees(i, 1, n);
        }
        return retVal;
    }

    private int GenerateTrees(int rootVal, int startNumber, int endNumber)
    {
        int leftNodes = 0;
        int rightNodes = 0;
        int retVal;

        if (dp[rootVal - startNumber][endNumber - rootVal] != 0 || dp[rootVal - startNumber][endNumber - rootVal] != 0)
        {
            return 0 == dp[rootVal - startNumber][endNumber - rootVal] ? dp[rootVal - startNumber][endNumber - rootVal] : dp[rootVal - startNumber][endNumber - rootVal];
        }


        for (int i = startNumber; i < rootVal; i++)
        {
            leftNodes += GenerateTrees(i, startNumber, rootVal - 1);
        }

        for (int i = rootVal + 1; i <= endNumber; i++)
        {
            rightNodes += GenerateTrees(i, rootVal + 1, endNumber);
        }

        retVal = (leftNodes == 0 ? 1 : leftNodes) * (rightNodes == 0 ? 1 : rightNodes);

        dp[rootVal - startNumber][endNumber - rootVal] = retVal;
        return retVal;
    }
}