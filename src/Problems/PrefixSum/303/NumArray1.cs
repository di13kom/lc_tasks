using System;

namespace LeetCode.Problems.PrefixSum._303;

public class NumArray1
{
    readonly int[] _nums;
    readonly int _sum;
    public NumArray1(int[] nums)
    {
        _nums = nums;
        foreach (var item in nums)
        {
            _sum += item;
        }
    }

    public int SumRange(int left, int right)
    {
        if (left == right)
            return _nums[left];

        return _sum - SumX(0, left) - SumX(++right, _nums.Length);
    }

    private int SumX(int left, int right)
    {
        int retVal = 0;
        for (int i = left; i < right; i++)
        {
            retVal += _nums[i];
        }
        return retVal;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */