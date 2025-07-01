namespace LeetCode.Problems._35;

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        if (nums[0] == target)
            return 0;
        return BinarySearchIdxInsert(nums, target);
    }
    int BinarySearchIdxInsert(int[] array, int targetValue)
    {
        if (array.Length <= 1 && array[0] <= targetValue)
            return 1;
        if (array[0] >= targetValue)
            return 0;

        var middleIndex = array.Length / 2;
        if (array[middleIndex] < targetValue)
        {
            return middleIndex + BinarySearchIdxInsert(array[middleIndex..], targetValue);
        }
        else
        {
            return BinarySearchIdxInsert(array[0..middleIndex], targetValue);
        }
    }
}