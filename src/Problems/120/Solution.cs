using System;
using System.Diagnostics;

namespace LeetCode.Problems._120;

public class Solution
{
    IList<IList<int>> memo = [];
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        return MinimumTotalRecursive(triangle, 0, 0);
    }

    private int MinimumTotalRecursive(IList<IList<int>> triangle, int curLevel, int curIdx)
    {
        int retVal = int.MaxValue;
        var curValue = triangle[curLevel][curIdx];
        if (curLevel == triangle.Count - 1)
        {
            // Debug.WriteLine($"Current sum:{curValue}");
            return curValue;
        }
        if (memo.Count < curLevel + 1)
            memo.Add(new List<int>(Enumerable.Repeat(int.MaxValue, triangle[curLevel].Count)));

        for (int i = 0; i < 2; i++)
        {
            if (memo[curLevel][curIdx] == int.MaxValue)
            {
                retVal = Math.Min(retVal, curValue + MinimumTotalRecursive(triangle, curLevel + 1, curIdx + i));
            }
            else
            {
                // Debug.WriteLine($"Try use map: level:{curLevel} curIdx:{curIdx} memo:{memo[curLevel][curIdx]}");
                return memo[curLevel][curIdx];
            }
        }
        memo[curLevel][curIdx] = retVal;

        return retVal;
    }
}
