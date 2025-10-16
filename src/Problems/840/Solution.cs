
namespace LeetCode.Problems._840;

public class Solution
{
    const int SquareSize = 3;
    int _gridWidth;
    int _gridHeigth;
    public int NumMagicSquaresInside(int[][] grid)
    {
        int retVal = 0;
        _gridWidth = grid[0].Length;
        _gridHeigth = grid.Length;

        if (_gridHeigth < 3 || _gridWidth < 3)
            return retVal;

        for (int i = 0; i <= _gridHeigth - SquareSize; i++)
        {
            for (int j = 0; j <= _gridWidth - SquareSize; j++)
            {
                retVal += IsMagicSquare(grid, i, j) ? 1 : 0;
            }
        }

        return retVal;
    }

    private bool IsMagicSquare(int[][] grid, int i, int j)
    {
        bool retVal;
        HashSet<int> uniqueInts = [];
        for (int k = i; k < i + SquareSize; k++)
        {
            for (int n = j; n < j + SquareSize; n++)
            {
                if (!uniqueInts.Add(grid[k][n]) || grid[k][n] > 9 || grid[k][n] < 1)
                    return false;
            }
        }
        int sum = grid[i + 0][j + 0] + grid[i + 0][j + 1] + grid[i + 0][j + 2];
        if (
            sum == (grid[i + 0][j + 0] + grid[i + 0][j + 1] + grid[i + 0][j + 2]) &&
            sum == (grid[i + 1][j + 0] + grid[i + 1][j + 1] + grid[i + 1][j + 2]) &&
            sum == (grid[i + 2][j + 0] + grid[i + 2][j + 1] + grid[i + 2][j + 2]) &&

            sum == (grid[i + 0][j + 0] + grid[i + 1][j + 0] + grid[i + 2][j + 0]) &&
            sum == (grid[i + 1][j + 0] + grid[i + 1][j + 1] + grid[i + 1][j + 2]) &&
            sum == (grid[i + 2][j + 0] + grid[i + 2][j + 1] + grid[i + 2][j + 2]) &&

            sum == (grid[i + 0][j + 0] + grid[i + 1][j + 1] + grid[i + 2][j + 2]) &&
            sum == (grid[i + 2][j + 0] + grid[i + 1][j + 1] + grid[i + 0][j + 2])
            )
            retVal = true;
        else
            retVal = false;

        return retVal;
    }
}