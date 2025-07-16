namespace LeetCode.Problems._69;

public class Solution
{
    public int MySqrt(int x)
    {
        if (x == 0)
            return 0;
        var max = x;
        if (max > 46340)
        {
            max = 46340;
        }


        int[] values = Enumerable.Range(1, max).ToArray();

        return BinarySearchIdxInsert(values, x);
    }

    int BinarySearchIdxInsert(int[] array, int targetValue)
    {
        if (array.Length <= 1 && array[0] <= targetValue)
            return 1;
        if (array[0] >= targetValue)
            return 0;

        var middleIndex = array.Length / 2;
        if (array[middleIndex] * array[middleIndex] <= targetValue)
        {
            return middleIndex + BinarySearchIdxInsert(array[middleIndex..], targetValue);
        }
        else
        {
            return BinarySearchIdxInsert(array[0..middleIndex], targetValue);
        }
    }
}