namespace LeetCode.Problems._3446;

public class Solution
{
    public int[][] SortMatrix(int[][] grid)
    {
        int[][] retVal = new int[grid.Length][];
        for (int i = 0; i < grid.Length; i++)
        {
            retVal[i] = new int[grid[i].Length];
        }

        DiagonalOrderDesc(grid, 0, 0, retVal, false);
        for (int i = 1; i < grid.Length; i++)
        {
            DiagonalOrderDesc(grid, i, 0, retVal, false);
            DiagonalOrderDesc(grid, 0, i, retVal, true);
        }

        return retVal;
    }

    private void DiagonalOrderDesc(int[][] grid, int startX, int startY, int[][] retVal, bool isOrderAsc)
    {
        int height = grid.Length;
        int width = grid[0].Length;
        List<int> ints = [];
        int currentX = startX;
        int currentY = startY;

        while (currentX < width && currentY < height)
        {
            ints.Add(grid[currentX++][currentY++]);
        }
        currentX = startX;
        currentY = startY;
        foreach (var item in isOrderAsc ? ints.Order() : ints.OrderDescending())
        {
            retVal[currentX++][currentY++] = item;
        }
    }
}