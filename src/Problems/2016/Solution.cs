using System;

namespace LeetCode.Problems._2016;

public class Solution
{
    public int MaximumDifference(int[] nums)
    {
        int retVal = -1;
        int minValue = int.MaxValue;
        int maxValue = short.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (minValue > nums[i])
            {
                minValue = nums[i];
                maxValue = short.MinValue;
            }
            maxValue = (maxValue < nums[i] && nums[i] > minValue) ? nums[i] : maxValue;

            retVal = retVal > (maxValue - minValue) ? retVal : maxValue - minValue;
        }

        return retVal;
    }
}