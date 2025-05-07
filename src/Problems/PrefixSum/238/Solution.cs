using System;

namespace LeetCode.Problems.PrefixSum._238;

public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var length = nums.Length;
        int[] retVal = new int[length];
        int[] leftProduct = new int[length];
        int prevLeftProduct = 1;
        int[] RightProduct = new int[length];
        int prevRightProduct = 1;

        for (int i = 0, j = length - 1; i < length; i++, j--)
        {
            leftProduct[i] = prevLeftProduct;
            RightProduct[j] = prevRightProduct;

            prevLeftProduct *= nums[i];
            prevRightProduct *= nums[j];
        }

        for (int i = 0; i < length; i++)
        {
            retVal[i] = leftProduct[i] * RightProduct[i];
        }

        return retVal;
    }
}