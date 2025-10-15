namespace LeetCode.Problems._1351;

public class Solution
{
    public int CountNegatives(int[][] grid)
    {
        int retVal = 0;
        int axisLength = grid.Length;
        int length = grid[0].Length;
        for (int i = 0; i < axisLength; i++)
        {
            if (grid[i][0] < 0)
            {
                retVal += length;
                continue;
            }
            if (grid[i][0] > 0 && grid[i][length - 1] > 0)
            {
                retVal += 0;
                continue;
            }
            for (int j = 0; j < length; j++)
            {
                if (grid[i][j] < 0)
                {
                    retVal += length - j;
                    break;
                }
            }

        }
        return retVal;
    }
}