using System;

namespace LeetCode.Problems._2873;

public class Solution
{
    public long MaximumTripletValue(int[] nums)
    {
        long retVal = long.MinValue;
        long curValue;
        for (int i = 2; i < nums.Length; i++)
        {
            for (int j = 1; j < i; j++)
            {
                for (int k = 0; k < j; k++)
                {
                    curValue = ((long)nums[k] - nums[j]) * nums[i];
                    if (curValue > retVal)
                        retVal = curValue;
                }

            }
        }

        return retVal > 0 ? retVal : 0;

    }
}