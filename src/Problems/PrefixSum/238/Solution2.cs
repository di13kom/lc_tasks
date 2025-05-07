using System;

namespace LeetCode.Problems.PrefixSum._238;

public class Solution2
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var length = nums.Length;
        int[] retVal = new int[length];
        int prevRightProduct = 1;

        for (int j = length - 1; j >= 0; j--)
        {
            retVal[j] = prevRightProduct;

            prevRightProduct *= nums[j];
        }

        prevRightProduct = 1;
        for (int i = 0; i < length; i++)
        {
            retVal[i] *= prevRightProduct;

            prevRightProduct *= nums[i];
        }

        return retVal;
    }
}