using System.Reflection.PortableExecutable;

namespace LeetCode.Problems._3195;

public class Solution
{
    public int MinimumArea(int[][] grid)
    {
        int leftValue = int.MaxValue;
        int rightVale = int.MinValue;
        int? firstNonZeroRow = null;
        int LastNonZeroRow = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    firstNonZeroRow = firstNonZeroRow.HasValue ? firstNonZeroRow : i;
                    LastNonZeroRow = i;
                    if (j < leftValue)
                    {
                        leftValue = j;
                    }
                    if (j > rightVale)
                    {
                        rightVale = j;
                    }
                }
            }
        }
        return (rightVale - leftValue + 1) * (LastNonZeroRow - firstNonZeroRow.Value + 1);
    }
}