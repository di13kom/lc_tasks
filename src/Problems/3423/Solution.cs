using System;

namespace LeetCode.Problems._3423;

public class Solution
{
    public int MaxAdjacentDistance(int[] nums)
    {
        int length = nums.Length;
        int retVal = 0;
        for (int i = 1; i < length; i++)
        {
            retVal = Math.Max(Math.Abs(nums[i] - nums[i - 1]), retVal);
        }

        retVal = Math.Max(Math.Abs(nums[0] - nums[length - 1]), retVal);

        return retVal;

    }
}