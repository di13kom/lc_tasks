using System;

namespace LeetCode.Problems._3432;

public class Solution
{
    public int CountPartitions(int[] nums)
    {
        var sum = nums.Sum();
        int sumValuesLeft = 0;
        int retVal = 0;

        if (sum % 2 != 0)
            return 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if ((sum - sumValuesLeft - nums[i] - sumValuesLeft + nums[i]) % 2 == 0)
                retVal++;
        }

        return retVal;

    }
}