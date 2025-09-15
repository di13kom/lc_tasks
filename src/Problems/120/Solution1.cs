namespace LeetCode.Problems._120;

public class Solution1
{
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        return MinimumTotalRecursive(triangle, 0, 0, 0);
    }

    private int MinimumTotalRecursive(IList<IList<int>> triangle, int curLevel, int curSum, int curIdx)
    {
        int retVal = int.MaxValue;
        var aggregateSum = curSum + triangle[curLevel][curIdx];
        if (curLevel == triangle.Count - 1)
        {
            return aggregateSum;
        }

        for (int i = 0; i < 2; i++)
        {
            retVal = Math.Min(retVal, MinimumTotalRecursive(triangle, curLevel + 1, aggregateSum, curIdx + i));
        }

        return retVal;
    }
}