namespace LeetCode.Problems._229;

public class Solution
{
    const int nonMajoritySymbol = int.MinValue;
    public IList<int> MajorityElement(int[] nums)
    {
        HashSet<int> retVal = [];
        var length = nums.Length;
        if (length == 1)
            return [nums[0]];
        if (length == 2)
        {
            if (nums[0] == nums[1])
                return [nums[0]];
            else
                return [nums[0], nums[1]];
        }
        Array.Sort(nums);
        var firstSlice = nums[0..(1 * length / 3)];
        var secondSlice = nums[(1 * length / 3)..(2 * length / 3)];
        var thirdSlice = nums[(2 * length / 3)..];
        var firstSliceMajorityInteger = FindMajorityElement(firstSlice);
        var secondSliceMajorityInteger = FindMajorityElement(secondSlice);
        var thirdSliceMajorityInteger = FindMajorityElement(thirdSlice);

        if (SliceContainsInteger(secondSlice, firstSliceMajorityInteger.Item1, length / 3 - firstSliceMajorityInteger.Item2 + 1))
            retVal.Add(firstSliceMajorityInteger.Item1);
        if (SliceContainsInteger(firstSlice, secondSliceMajorityInteger.Item1, length / 3 - secondSliceMajorityInteger.Item2 + 1)
                || SliceContainsInteger(thirdSlice, secondSliceMajorityInteger.Item1, length / 3 - secondSliceMajorityInteger.Item2 + 1))
            retVal.Add(secondSliceMajorityInteger.Item1);
        if (SliceContainsInteger(secondSlice, thirdSliceMajorityInteger.Item1, length / 3 - thirdSliceMajorityInteger.Item2 + 1))
            retVal.Add(thirdSliceMajorityInteger.Item1);

        return retVal.ToList();
    }

    private (int, int) FindMajorityElement(Span<int> nums)
    {
        var length = nums.Length;
        int firstElem = nums[0];
        int firstElemCount = 1;

        for (int i = 1; i < length; i++)
        {
            if (nums[i] == firstElem)
            {
                firstElemCount++;
            }
            else
            {
                if (--firstElemCount == 0)
                {
                    firstElem = nums[i];
                    firstElemCount = 1;
                }
            }
        }

        if (firstElemCount == length)
            return (firstElem, firstElemCount);

        firstElemCount = 0;
        for (int i = 0; i < length; i++)
        {
            if (nums[i] == firstElem)
                firstElemCount++;
        }

        return (firstElem, firstElemCount);
    }

    private bool SliceContainsInteger(Span<int> nums, int target, int count)
    {
        var length = nums.Length;
        var cnt = 0;
        for (int i = 0; i < length; i++)
        {
            if (nums[i] == target)
                cnt++;
            if (cnt - count == 0)
                return true;
        }
        return false;
    }
}
