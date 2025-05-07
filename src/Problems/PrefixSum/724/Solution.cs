using System;

namespace LeetCode.Problems.PrefixSum._724;

public class Solution
{
    public int PivotIndex(int[] nums)
    {
        var length = nums.Length;
        int[] leftSum = new int[length];
        int prevLeftSum = 0;
        int[] RightSum = new int[length];
        int prevRightSum = 0;

        for (int i = 0, j = length - 1; i < length; i++, j--)
        {
            leftSum[i] = prevLeftSum;
            RightSum[j] = prevRightSum;

            prevLeftSum += nums[i];
            prevRightSum += nums[j];
        }

        for (int i = 0; i < length; i++)
        {
            if (leftSum[i] == RightSum[i])
                return i;
        }

        return -1;
    }
}