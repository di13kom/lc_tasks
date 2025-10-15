namespace LeetCode.Problems._1351;

public class Solution1
{
    public int CountNegatives(int[][] grid)
    {
        int retVal = 0;
        int axisLength = grid.Length;
        int length = grid[0].Length;
        for (int i = 0; i < axisLength; i++)
        {
            int res = BinaryReverseSearchIdxInsert(grid[i], -1);
            if (res > 0)
            {
                retVal += length - res;
            }
            else
            {
                retVal += length - res;
            }
        }
        return retVal;
    }

    int BinaryReverseSearchIdxInsert(int[] array, int targetValue)
    {
        int length = array.Length;
        if (array[0] <= targetValue)
            return 0;
        if (length <= 1 && array[0] <= targetValue)
            return 0;
        if (length <= 1 && array[0] >= targetValue)
            return 1;

        var middleIndex = length / 2;
        if (array[middleIndex] >= targetValue)
        {
            return middleIndex + BinaryReverseSearchIdxInsert(array[middleIndex..], targetValue);
        }
        else
        {
            return BinaryReverseSearchIdxInsert(array[..middleIndex], targetValue);
        }
    }
}