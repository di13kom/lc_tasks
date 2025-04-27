using System;

namespace LeetCode.Problems._2965;

public class Solution
{
    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        int[] retVal = new int[2];
        Dictionary<int, int> dict = [];
        int maxValue = grid.Length * grid[0].Length;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (!dict.TryAdd(grid[i][j], 1))
                {
                    dict[grid[i][j]] += 1;
                }
            }
        }
        retVal[0] = dict.Where(x => x.Value % 2 == 0).First().Key;

        foreach (var item in Enumerable.Range(1, maxValue))
        {
            if (!dict.ContainsKey(item))
            {
                retVal[1] = item;
                break;
            }
        }

        return retVal;

    }
}
