namespace LeetCode.Problems._46;

public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> retVal = [];
        var length = nums.Length;
        if (length == 1)
            return [nums];
        for (int i = 0; i < length; i++)
        {
            (nums[i], nums[0]) = (nums[0], nums[i]);
            PermuteInternal(nums, 1, retVal);
            (nums[i], nums[0]) = (nums[0], nums[i]);
        }

        return retVal;
    }

    private void PermuteInternal(int[] ints, int idx, IList<IList<int>> intsList)
    {
        var length = ints.Length;
        if (idx == (length - 1))
        {
            (ints[idx - 1], ints[idx]) = (ints[idx], ints[idx - 1]);
            intsList.Add([.. ints]);
            (ints[idx - 1], ints[idx]) = (ints[idx], ints[idx - 1]);
            return;
        }
        for (int i = idx; i < length; i++)
        {
            (ints[i], ints[idx]) = (ints[idx], ints[i]);
            PermuteInternal(ints, idx + 1, intsList);
            (ints[i], ints[idx]) = (ints[idx], ints[i]);
        }
    }
}